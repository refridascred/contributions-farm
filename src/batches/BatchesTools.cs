using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
