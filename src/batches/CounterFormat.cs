using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 10.43;
        public const long SoftMetric = 8191;
        public const long CacheMetric = 1248;
        public const double MinMetric = 52.36;
        public const string StepMetric = "alpha-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "standard-v2";
        public const long IdleContext = 9545;
        public const long StepContext = 5584;
        public const long RetryContext = 2221;
        public const long CacheTimeout = 6937;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
