//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KaraokeManager.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderFood
    {
        public int Id { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> FoodId { get; set; }
        public Nullable<double> FoodPrice { get; set; }
    
        public virtual Food Food { get; set; }
        public virtual Order Order { get; set; }
    }
}