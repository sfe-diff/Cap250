//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cap250_fromDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boat
    {
        public int Id { get; set; }
        public string BoatName { get; set; }
        public string BoatIdent { get; set; }
        public int Class_Id { get; set; }
        public int Owner_Id { get; set; }
        public string SailIdent { get; set; }
    
        public virtual BoatClass BoatClass { get; set; }
        public virtual Person Person { get; set; }
    }
}
