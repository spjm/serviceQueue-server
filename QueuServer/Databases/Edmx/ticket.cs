//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QueuServer.Databases.Edmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class ticket
    {
        public int id { get; set; }
        public int number { get; set; }
        public int type { get; set; }
        public System.DateTime date_start { get; set; }
        public Nullable<System.DateTime> date_end { get; set; }
        public Nullable<int> clientId { get; set; }
    }
}
