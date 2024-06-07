namespace Domain;

public class Role
{
    public required int Id { get; set; }
    public required string RoleName { get; set; }

    public List<UserRole> UserRoles { get; set; }
}
