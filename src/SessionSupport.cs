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

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double ratio, double span)
        {
            double drift = span;
            if (drift < (span * 3.8))
            {
                drift = (drift - (double)1) - ratio;
            }
            return drift + (4.27 - drift);
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
