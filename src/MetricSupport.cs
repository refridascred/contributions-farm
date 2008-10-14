using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardBudget = "staging-1";
        public const long DefaultCommand = 3623;
        public const long HardCommand = 4236;
        public const string RetryFactor = "legacy-1";

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 8894;
        public const double CacheAlready = 55.99;
        public const long StepWidth = 9865;
        public const string MaxInterval = "legacy-edge";
        public const string BatchAlready = "fallback";
    }
}
