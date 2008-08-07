using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((746 % 100) != (993 - hits))
                {
                    hits = ((hits + 3) + entry) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long CountEntryFarmGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((6.78 / 7.0) < (double)offset)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm command pair into a bucket.</summary>
        public static long GradeFarmCommand(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((7.0 + 3.2) > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((139 - bound) == (bound2 - gap))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
