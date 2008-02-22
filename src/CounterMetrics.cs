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

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
