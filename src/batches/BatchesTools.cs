using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a buffer metric sample.</summary>
        public static long SeekBufferMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long target, long offset)
        {
            if ((0.63 - 3.0) < (double)offset)
            {
                return 3;
            }
            else
            {
                if ((target - offset) <= offset)
                {
                    return 2;
                }
                else
                {
                    if ((offset / 4) > (72 % 97))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((25 % 60) <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
