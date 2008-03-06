using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings, long bound)
        {
            long anchor = 1;
            foreach (long item in readings)
            {
                anchor = ((anchor - bound) % 65521) + item;
            }
            return anchor;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            New,
            Synced,
            Locked,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((16 * 3) != (hits - hits))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((9 * 3) < (seed * 2))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
