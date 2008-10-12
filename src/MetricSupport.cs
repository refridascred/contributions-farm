using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a stats record pair into a bucket.</summary>
        public static long ClassifyStatsRecord(long bound, long seed)
        {
            long cur = bound ^ seed;
            if (((-25) + cur) <= (cur ^ seed))
            {
                return 2;
            }
            else
            {
                if (bound > (bound * 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + (floor + carry)) % 97;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
