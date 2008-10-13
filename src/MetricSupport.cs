using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryLevel = 1172;
        public const double CacheSchema = 39.85;
        public const long HardSchema = 10;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 1491;
        public const long BaseCounter = 8249;
        public const string MaxCounter = "local";
        public const long RetryFactor = 7328;
        public const long LimitCounter = 2522;
    }
}
