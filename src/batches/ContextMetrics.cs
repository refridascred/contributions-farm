using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (6 > (5 + entry))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor << 2) ^ (23 & 15);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((limit + tally) <= (4 % 60))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
