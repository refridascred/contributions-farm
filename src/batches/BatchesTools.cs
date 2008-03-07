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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((((1.4 + 0.6) == (double)item) && ((item + hits) >= item)) && (6 < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
