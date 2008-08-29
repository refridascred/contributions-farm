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

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long floor)
        {
            long acc = 8;
            foreach (long datum in readings)
            {
                if (((acc - (-43)) >= acc) && ((acc - datum) > floor))
                {
                    acc = (acc ^ (floor / 2)) % 97;
                }
                else
                {
                    acc = (acc ^ 34) % 101;
                }
            }
            return acc;
        }
    }
}
