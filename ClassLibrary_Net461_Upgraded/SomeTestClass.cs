using ClassLibrary_NetStandard20;
using Xunit;

namespace ClassLibrary_Net461_Upgraded
{
    public class SomeTestClass
    {
        [Fact]
        public void SomeTestMethod()
        {
            var c = new Class1();
            Assert.Equal("ClassLibrary_NetStandard20.Class1", c.ToString());
        }
    }
}
