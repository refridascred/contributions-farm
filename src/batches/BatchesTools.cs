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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long seed, long limit)
        {
            long span = seed - limit;
            if (((-70) + limit) <= seed)
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (((span ^ seed) >= (seed >> 2)) || ((-2) <= (seed & 15)))
                    {
                        return 0;
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
