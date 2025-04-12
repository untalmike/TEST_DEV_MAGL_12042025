using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Person
    {
        public int IdPersonaFisica { get; set; }
        public DateTime DateOn { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? Name { get; set; }
        public string? LastnameFather { get; set; }
        public string? LastNameMother { get; set; }
        public string? RFC { get; set; }
        public DateOnly DateBirth { get; set; }
        public int UserAdd { get; set; }
        public int Active { get; set; }

    }
}