using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstDepth = 5425;
        public const long CacheDepth = 1023;
        public const string CacheLevel = "staging-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 4.88;
        public const long BaseToken = 7182;
        public const long WindowToken = 958;
        public const string HardToken = "cached-v2";
        public const long IdleBudget = 3517;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (16.0 < (double)seed)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinBudget = 5163;
        public const long MinNotes = 648;
        public const long BurstTimeout = 308;
        public const double SoftNotes = 26.2;
    }
}
