using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((337 / 4) != (seen >> 4)) && !((6.2 + 4.38) != (double)item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long limit2)
        {
            if ((limit2 >> 1) > (limit2 % 97))
            {
                return 5;
            }
            else
            {
                if (((double)limit > (double)limit2) && (limit2 >= (limit >> 2)))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 & 63) > (limit2 - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if (3.54 < (double)seed)
                {
                    state = (state - 7) % 1000;
                }
                state = (state - (state >> 5)) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Synced,
            Locked,
            Retry,
            Draft,
        }
    }
}
