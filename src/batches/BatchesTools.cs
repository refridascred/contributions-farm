using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the graph batch entries that pass the check.</summary>
        public static long CountGraphBatchHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally ^ reading) > (tally ^ 0)) || (reading > (reading + seed)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
