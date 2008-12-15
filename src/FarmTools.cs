using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseLevel = 1116;
        public const long RetryBudget = 5404;
        public const long SoftScore = 499;
        public const double BatchRatio = 1.14;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 3524;
        public const string BurstWidth = "fallback";
        public const string BaseSession = "staging-edge";
        public const long StepTimeout = 5045;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "primary";
        public const long BatchSpan = 9641;
        public const long CacheCluster = 1723;
        public const long MinCluster = 4832;
        public const long DefaultCluster = 3472;
    }
}
