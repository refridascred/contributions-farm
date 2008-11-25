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

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
