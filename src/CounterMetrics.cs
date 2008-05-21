using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a metrics layout reading by value.</summary>
        public static long SeekMetricsLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Locked,
            Paused,
            Retry,
            New,
        }

        /// <summary>Accumulate format account samples.</summary>
        public static long WeighFormatAccount(long[] levels, long seed)
        {
            long carry = -770;
            foreach (long entry in levels)
            {
                carry = (carry - seed) ^ entry;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many cache commits samples are out of range.</summary>
        public static long MeasureCacheCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((long)values.Length ^ tally) == (61 - 5)) || ((246 + tally) == (tally % 64)))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
