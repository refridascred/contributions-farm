using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long sum = 0;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum - limit) % 65521) + entry;
                    sum = (sum + (long)i) % 65521;
                }
                sum = (sum * 2) + (limit % 7);
            }
            if (sum > (-32))
            {
                sum = ((sum * 2) + (44 - sum)) % 97;
            }
            return sum;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long limit, long bound)
        {
            long slot = limit ^ bound;
            if ((limit << 2) != (423 + slot))
            {
                return 4;
            }
            else
            {
                if ((limit * 3) < bound)
                {
                    return 1;
                }
                else
                {
                    if ((slot ^ 53) >= (17 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((4.46 * 5.17) >= (double)bound) || (8.0 < (double)slot))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
