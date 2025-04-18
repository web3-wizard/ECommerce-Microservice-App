using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProductApi.Domain.Constants;

namespace ProductApi.Domain.Entities;

public class Product
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(DBConstraint.PRODUCT_NAME_MAX_LENGTH)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(DBConstraint.PRODUCT_MIN_QUANTITY, DBConstraint.PRODUCT_MAX_QUANTITY)]
    public int Quantity { get; set; }

    [Required]
    [Column(TypeName = "decimal(18,2)")]
    [Range((double)DBConstraint.PRODUCT_MIN_PRICE, (double)DBConstraint.PRODUCT_MAX_PRICE)]
    public decimal Price { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
