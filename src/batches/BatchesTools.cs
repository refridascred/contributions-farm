using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] series, long offset)
        {
            long carry = 493;
            foreach (long entry in series)
            {
                carry = ((carry << 3) ^ (carry >> 3)) % 97;
                if (carry > entry)
                {
                    carry = ((carry * 2) + offset) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long seed)
        {
            if (((double)floor <= (8.7 / 4.0)) && ((floor ^ floor) == (floor << 3)))
            {
                return 3;
            }
            else
            {
                if ((floor + seed) == (0 / 7))
                {
                    return 5;
                }
                else
                {
                    if ((floor & 1) < (floor << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
