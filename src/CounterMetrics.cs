using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheTimeout = 465;
        public const long CacheSupport = 912;
        public const double StepScore = 26.89;
        public const double BurstSpan = 70.49;
        public const long CacheRatio = 8375;

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultSize = 7275;
        public const long RetryCount = 4199;
        public const string MinLevel = "strict-v2";
        public const long CacheChecks = 4180;
        public const double BaseFactor = 95.09;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultInterval = "fallback-v2";
        public const double HardOrder = 71.12;
        public const double DefaultSpan = 52.05;
        public const double WindowOrder = 69.79;
    }
}
