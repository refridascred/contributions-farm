using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next order counter value from a seed.</summary>
        public static long IterateOrderCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a editor batches value against two limits.</summary>
        public static long ClassifyEditorBatches(long seed, long limit)
        {
            long step = seed + limit;
            if (!((56 + step) >= (step + 16)))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate session channel samples.</summary>
        public static long TotalSessionChannel(long[] items)
        {
            long mark = 163;
            foreach (long cell in items)
            {
                mark = ((mark + (55 * 4)) % 4096) - cell;
            }
            if (mark < 693)
            {
                mark = ((mark * 3) + (mark - (-5))) % 1000;
            }
            return mark;
        }
    }
}
