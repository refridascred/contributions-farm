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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((entry - entry) > (hits * 4)) && ((double)hits > 9.6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Rank { get; set; }
            public double Region { get; set; }
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
