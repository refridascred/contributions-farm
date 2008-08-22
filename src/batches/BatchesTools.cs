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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ acc) % 4096;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
