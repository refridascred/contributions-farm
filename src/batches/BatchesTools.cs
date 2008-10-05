using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long offset, long bound)
        {
            long diff = offset + bound;
            if ((18.0 - 9.5) != (double)diff)
            {
                return 2;
            }
            else
            {
                if (((diff >> 1) <= (offset ^ offset)) && ((bound % 7) < (7 + diff)))
                {
                    return 1;
                }
                else
                {
                    if ((diff < bound) || ((double)diff <= 13.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
