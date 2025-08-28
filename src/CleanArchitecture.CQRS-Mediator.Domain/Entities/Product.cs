namespace CleanArchitecture.CQRS_Mediator.Domain.Entities;

public class Product
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Stock { get; set; }
}