using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 5817;
        public const long CacheRoute = 292;
        public const long MaxRoute = 8638;

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "latest-edge";
        public const long StepBudget = 1946;
        public const string RetryFactor = "strict-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 3331;
        public const string MinCount = "staging-v2";
        public const long WindowGithubfarm = 1775;
        public const long BaseTimeout = 2469;
    }
}
