using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!(origin >= (2 >> 4)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)target <= 1.5)
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryPayload = "legacy-v2";
        public const double BurstPayload = 23.84;
        public const long BatchBudget = 8319;

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
