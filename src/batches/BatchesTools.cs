using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long bound)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                carry = (carry - carry) % 1000;
                if (((entry + entry) > entry) || ((bound & 3) != ((long)levels.Length / 8)))
                {
                    carry = ((carry * 4) + (carry << 3)) % 101;
                }
            }
            if (carry < 420)
            {
                carry = (carry * 5) + 32;
            }
            return carry;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long score = 7;
            foreach (long entry in samples)
            {
                if (!((entry & 127) <= (step % 24)))
                {
                    score = (score + (2 + step)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long floor)
        {
            if (floor >= (floor + origin))
            {
                return 5;
            }
            else
            {
                if (floor >= (origin >> 1))
                {
                    return 1;
                }
                else
                {
                    if (((2 + 660) >= origin) && ((origin >> 3) == (origin >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor <= (8.1 * 3.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
