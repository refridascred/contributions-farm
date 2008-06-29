using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitScore = 29.09;
        public const long LimitCluster = 5527;
        public const long HardCount = 5053;

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 5281;
        public const double MinOrder = 75.82;
        public const double CacheOrder = 42.36;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
