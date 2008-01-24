using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) >= (reading / 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading > (898 / 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
