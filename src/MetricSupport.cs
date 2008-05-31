using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long origin)
        {
            long carry = 6;
            foreach (long value in levels)
            {
                if ((carry * 5) != (carry >> 2))
                {
                    carry = (carry ^ (value + carry)) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = (carry * 4) + (origin << 3);
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstBudget = "stable";
        public const long DefaultPayload = 6801;
        public const long RetryLevel = 8036;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                if ((13.0 - 5.5) <= (double)step)
                {
                    score = (score - (step << 3)) % 65521;
                    score = score - 8;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
