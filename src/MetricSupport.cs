using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9842;
        public const long BatchSpan = 7974;
        public const double MaxEditor = 37.93;
        public const long SoftEditor = 1211;

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryTimeout = 8462;
        public const long BaseRatio = 5800;
        public const long CacheCommand = 3573;
    }
}
