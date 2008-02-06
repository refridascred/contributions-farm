using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item << 3) < 82) || (6 >= (hits + 422)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = mean + (ratio - mean);
            }
            return mean + (mean - bias);
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Pending,
            Locked,
            Queued,
        }
    }
}
