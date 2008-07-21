using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Queued,
            Failed,
        }
    }
}
