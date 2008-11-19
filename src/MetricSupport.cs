using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Size { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseDepth = "fallback-1";
        public const double StepSize = 16.85;
        public const long WindowTimeout = 8409;
        public const long CacheContext = 6684;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
