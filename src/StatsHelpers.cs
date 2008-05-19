using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Locked,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 7025;
        public const long CacheStats = 3490;
        public const double SoftStats = 11.19;
        public const double BaseSize = 67.56;
        public const long MinInterval = 4960;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Pending,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally - datum) == (850 / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
