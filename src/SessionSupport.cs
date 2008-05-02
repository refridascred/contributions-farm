using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry <= (29 & 127))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((reading << 1) == ((long)readings.Length * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Closed,
            Paused,
            Active,
            Pending,
        }
    }
}
