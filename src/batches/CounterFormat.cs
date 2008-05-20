using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)seen == (3.32 - 7.5)) && ((seen - seen) < (reading + bound)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Failed,
            Draft,
            Synced,
            Paused,
        }
    }
}
