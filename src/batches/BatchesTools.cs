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

        /// <summary>Rank queue tools input into a small class.</summary>
        public static long BucketQueueTools(long bound, long bound2)
        {
            if ((bound2 < (bound2 << 1)) || (266 > (bound + bound2)))
            {
                return 3;
            }
            else
            {
                if (!((5.4 * 2.0) >= (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
