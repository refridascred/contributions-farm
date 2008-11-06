using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)floor <= (double)datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
