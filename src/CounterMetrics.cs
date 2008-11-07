using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardMetric = 70.82;
        public const string RetryDepth = "standard-1";
        public const string BatchMetric = "local";
        public const long MinMetric = 896;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 3969;
        public const double LimitWidth = 9.37;
        public const long IdleRatio = 1076;
        public const long BatchGithubfarm = 8102;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 3957;
        public const long BaseCount = 2808;
        public const long RetryPayload = 8435;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Draft,
            Dropped,
        }
    }
}
