using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ftest.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitsOnOder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }
        public virtual Category Category { get; set; }
    }
}