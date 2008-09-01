using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((offset - count) < (count << 3)) || ((offset + count) != (12 - item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 83.93;
        public const long WindowMetric = 8772;
        public const long LimitDepth = 2953;
        public const long RetryMetric = 6034;
        public const string WindowBudget = "standard-1";

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
