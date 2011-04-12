// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.4.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace AttributeRouting.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Route Prefixes")]
    public partial class RoutePrefixesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RoutePrefixes.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Route Prefixes", "", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            this.FeatureBackground();
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("I generate the routes defined in the subject controllers");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating prefixed routes")]
        public virtual void GeneratingPrefixedRoutes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating prefixed routes", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.When("I fetch the routes for the RoutePrefixes controller\'s Index action");
#line 8
 testRunner.Then("the route url is \"Prefix/Index\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating prefixed routes when route urls specify a duplicate prefix")]
        public virtual void GeneratingPrefixedRoutesWhenRouteUrlsSpecifyADuplicatePrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating prefixed routes when route urls specify a duplicate prefix", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
 testRunner.When("I fetch the routes for the RoutePrefixes controller\'s DuplicatePrefix action");
#line 12
 testRunner.Then("the route url is \"Prefix/DuplicatePrefix\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating absolute routes when a route prefix is defined")]
        public virtual void GeneratingAbsoluteRoutesWhenARoutePrefixIsDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating absolute routes when a route prefix is defined", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.When("I fetch the routes for the RoutePrefixes controller\'s Absolute action");
#line 16
 testRunner.Then("the route url is \"PrefixAbsolute\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating prefixed area routes")]
        public virtual void GeneratingPrefixedAreaRoutes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating prefixed area routes", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.When("I fetch the routes for the AreaRoutePrefixes controller\'s Index action");
#line 20
 testRunner.Then("the route url is \"Area/Prefix/Index\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating prefixed area routes when route urls specify a duplicate prefix")]
        public virtual void GeneratingPrefixedAreaRoutesWhenRouteUrlsSpecifyADuplicatePrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating prefixed area routes when route urls specify a duplicate prefix", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line 23
 testRunner.When("I fetch the routes for the AreaRoutePrefixes controller\'s DuplicatePrefix action");
#line 24
 testRunner.Then("the route url is \"Area/Prefix/DuplicatePrefix\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating absolute routes when a route area and route prefix is defined")]
        public virtual void GeneratingAbsoluteRoutesWhenARouteAreaAndRoutePrefixIsDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating absolute routes when a route area and route prefix is defined", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.When("I fetch the routes for the AreaRoutePrefixes controller\'s Absolute action");
#line 28
 testRunner.Then("the route url is \"AreaPrefixAbsolute\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion