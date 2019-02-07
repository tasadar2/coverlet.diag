using Xunit;

namespace coverlet.diag.unittests
{
    public class FooTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var foo = new Foo();

            // Act
            var bar = foo.Bar();

            // Assert
            Assert.Equal("bar", bar);
        }
    }
}