using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - hits) >= (hits & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long bound, long offset)
        {
            long next = bound - offset;
            if (next <= (next - offset))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) <= 9)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels, long offset)
        {
            long carry = 9;
            foreach (long sample in levels)
            {
                carry = (((carry * 2) + (948 - offset)) % 255) ^ sample;
            }
            return carry;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long carry = 58;
            foreach (long item in samples)
            {
                if ((item << 3) >= carry)
                {
                    carry = (carry + item) % 4096;
                }
            }
            if (carry > 835)
            {
                carry = ((carry << 2) ^ (carry * 4)) % 97;
            }
            return carry;
        }
    }
}
