using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long bound)
        {
            long slot = floor + bound;
            if ((slot + slot) <= (439 / 5))
            {
                return 8;
            }
            else
            {
                if ((floor + slot) != (851 - bound))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of queue session readings.</summary>
        public static long PairQueueSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long limit, long floor)
        {
            long diff = limit ^ floor;
            if ((floor - 755) >= (limit % 5))
            {
                return 5;
            }
            else
            {
                if ((4.7 * 7.9) <= (double)diff)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit < 5.3)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((diff >> 2) != (limit << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
