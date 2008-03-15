using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardRatio = "fallback-v2";
        public const long DefaultCluster = 2904;
        public const long StepSpan = 347;
        public const long MinLevel = 4133;
        public const long SoftWidth = 7114;

        /// <summary>Define format limits and defaults.</summary>
        public const string StepWidth = "legacy-edge";
        public const long RetryBudget = 6970;
        public const long BatchFormat = 505;
        public const double SoftFormat = 5.28;

        /// <summary>Define route limits and defaults.</summary>
        public const string HardDepth = "local-1";
        public const long StepRoute = 44;
        public const long BatchTimeout = 4680;
        public const long CacheRoute = 67;
        public const double BatchSpan = 74.47;
    }
}
