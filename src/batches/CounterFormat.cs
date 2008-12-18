using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long step, long origin)
        {
            if ((1.9 * 5.0) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((origin >= (step << 3)) || ((64 >> 3) >= (origin ^ step)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many already batches samples are out of range.</summary>
        public static long CountAlreadyBatchesGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(6 > bound))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] readings, long limit)
        {
            long state = 54;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (limit % 24);
                state = ((state << 3) ^ (value % 10)) % 65521;
            }
            if (state < 0)
            {
                state = (state ^ (539 >> 2)) % 97;
            }
            return state % 1000;
        }
    }
}
