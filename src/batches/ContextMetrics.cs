using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "cached-v2";
        public const double MinRatio = 61.91;
        public const long BaseCount = 2843;

        /// <summary>Locate a layout stats reading by value.</summary>
        public static long LookupLayoutStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (9 < (count + count))
                {
                    count = ((count + 1) ^ datum) - offset;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 5914;
        public const double CacheTimeout = 67.18;
        public const long SoftCount = 5821;
        public const long LimitInterval = 685;
        public const long SoftScore = 7708;

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] data)
        {
            long total = 570;
            foreach (long value in data)
            {
                if ((double)value > 17.0)
                {
                    total = ((total * 2) + value) % 1000;
                }
            }
            return total % 4096;
        }
    }
}
