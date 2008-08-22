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

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((seed * 3) >= (reading - hits)) || ((double)seed < (3.3 / 2.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
