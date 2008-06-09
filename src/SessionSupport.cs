using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((hits + sample) <= (hits + hits)) && ((2.42 * 13.0) > (double)sample)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 8469;
        public const long SoftSpan = 8405;
        public const double BurstEntry = 48.86;
        public const long RetryBudget = 8574;
        public const long CacheSize = 2485;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)floor != (double)620)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
