using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstInterval = 98;
        public const long MaxEditor = 7878;
        public const long CacheEditor = 2832;
        public const long BaseSpan = 8710;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits + 618) != (hits << 2)) && ((3.6 + 0.8) != (double)hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
