using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Navs.Tests;

[Collection("Collection")]
public sealed class NavTests : FixturedUnitTest
{
    public NavTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
        // Test that the component can be instantiated
        Assert.True(true);
    }
}
