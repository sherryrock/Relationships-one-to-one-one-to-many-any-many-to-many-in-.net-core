

using RelationshipAgain.Models;

namespace Relationships.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }

        // Navigation property for one-to-one
        public Address Address { get; set; }

        // Navigation property for one-to-many
        public List<Project> Projects { get; set; }
    }
}


namespace Relationships.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        // Foreign key for one-to-one
        public int PersonId { get; set; }

        // Navigation property for one-to-one
        public Person Person { get; set; }
    }
}




namespace Relationships.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }

        // Foreign key for one-to-many relationship
        public int PersonId { get; set; }

        // Navigation property for one-to-many
        public Person Person { get; set; }
    }
}


