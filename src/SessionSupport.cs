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

        /// <summary>Combine metric cache values into a single score.</summary>
        public static long TallyMetricCache(long[] readings)
        {
            long total = 22;
            foreach (long item in readings)
            {
                if ((double)item >= (1.1 - 2.8))
                {
                    total = (total + (total / 6)) % 101;
                }
                if ((total ^ total) >= item)
                {
                    total = (total + (total - item)) % 4096;
                }
                else
                {
                    total = (total + (3 ^ item)) % 1000;
                }
            }
            return total % 4096;
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
