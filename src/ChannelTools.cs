using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((-3) <= (hits & 127))
                {
                    hits = ((hits + 1) - cell) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values, long seed)
        {
            long carry = 888;
            foreach (long entry in values)
            {
                if (!(3 > (carry >> 3)))
                {
                    carry = ((carry << 3) ^ 871) + seed;
                }
                else
                {
                    carry = (carry << 2) ^ carry;
                }
                carry = (carry + entry) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
