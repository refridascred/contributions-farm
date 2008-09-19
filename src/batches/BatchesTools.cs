using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long carry = 78;
            foreach (long value in levels)
            {
                carry = (carry * 4) + (carry + value);
                if (((double)carry < (1.8 + 17.0)) || ((8 + 9) <= (value + value)))
                {
                    carry = carry - (value + carry);
                }
            }
            if (carry > 216)
            {
                carry = (carry ^ 787) % 97;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7423;
        public const string IdleWidth = "fallback-v2";
        public const long RetryTimeout = 8199;
        public const string IdleNotes = "latest";
        public const long DefaultNotes = 1813;

        /// <summary>Rank metrics cache input into a small class.</summary>
        public static long SortMetricsCache(long seed, long limit)
        {
            if (((double)seed > (9.42 - 1.0)) && ((seed + 261) >= limit))
            {
                return 3;
            }
            else
            {
                if (((double)limit >= (double)3) || ((double)404 <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
