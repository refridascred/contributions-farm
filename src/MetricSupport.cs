using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry % 60) >= (matches * 3))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 7874;
        public const double IdleScore = 77.0;
        public const string CacheWidth = "standard-v2";
        public const long BurstStream = 6061;
        public const string WindowStream = "standard-edge";
    }
}
