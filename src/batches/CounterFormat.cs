using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits < 8.1)
                {
                    hits = ((hits + 2) + value) + seed;
                }
            }
            return hits;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long seed, long target)
        {
            long offset = seed + target;
            if (((target + 47) > (8 + seed)) || (offset >= (offset / 8)))
            {
                return 4;
            }
            else
            {
                if ((target & 1) != (offset ^ target))
                {
                    return 1;
                }
                else
                {
                    if ((0.19 * 0.29) >= (3.13 + 6.2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.8 - 4.64) < (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}
