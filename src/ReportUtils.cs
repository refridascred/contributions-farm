using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of queue editor entries.</summary>
        public static long ScoreQueueEditor(long[] levels)
        {
            long anchor = 677;
            foreach (long cell in levels)
            {
                if (anchor < (cell & 127))
                {
                    anchor = anchor ^ cell;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Pending,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 8520;
        public const string BurstFactor = "alpha";
        public const long RetryRoute = 938;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits <= (8 & 127))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
