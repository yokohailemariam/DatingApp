namespace API.DTOs
{
    // this is dto need to be map to user entity 
    public class MemberUpdateDto
    {
        public string Introduction { get; set; }

        public string LookingFor { get; set; }

        public string Interests { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}