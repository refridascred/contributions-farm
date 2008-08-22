using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long floor, long offset)
        {
            if ((floor / 2) < floor)
            {
                return 0;
            }
            else
            {
                if ((floor + floor) <= (offset * 2))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] samples, long origin)
        {
            long state = 929;
            foreach (long value in samples)
            {
                state = (((state ^ (state >> 5)) % 4096) ^ value) - origin;
            }
            if (state < 8)
            {
                state = ((state * 2) + (state ^ state)) % 65521;
            }
            return state;
        }
    }
}
