using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleTimeout = 8105;
        public const long BatchMetric = 5894;
        public const long CacheMetric = 5845;
        public const long BurstMetric = 1379;
        public const long LimitMetric = 2725;

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long carry = 642;
            foreach (long entry in items)
            {
                if ((double)entry > (double)carry)
                {
                    carry = ((carry << 3) ^ (carry >> 2)) % 255;
                }
                else
                {
                    carry = (carry - (carry >> 5)) % 101;
                }
            }
            if (carry > 25)
            {
                carry = (carry + (carry & 7)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((count <= (561 - 39)) && (count < (count % 5))) && ((double)count > (1.0 - 4.05)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
