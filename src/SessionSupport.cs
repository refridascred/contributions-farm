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

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
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
