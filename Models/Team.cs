using System.ComponentModel.DataAnnotations;

public class Team {
    [Key]
    // dname id makes the field automatically a pomarau key 
    public string? TeamName { get; set; }
    public string? City { get; set; }
    public string? Province { get; set; }
    public string? Country { get; set; }

    public List<Player>? Players { get; set; }
}