using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long bound, long target)
        {
            if ((9.8 * 2.3) != (double)target)
            {
                return 6;
            }
            else
            {
                if (target < 2)
                {
                    return 1;
                }
                else
                {
                    if (bound >= (bound >> 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target & 3) > 6)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] readings)
        {
            long carry = 2;
            foreach (long datum in readings)
            {
                carry = (((carry * 4) + (carry + carry)) % 101) ^ datum;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples, long seed)
        {
            long acc = 87;
            foreach (long sample in samples)
            {
                acc = ((acc * 2) + (sample >> 1)) + seed;
            }
            return acc;
        }
    }
}
