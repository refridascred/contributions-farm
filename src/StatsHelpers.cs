using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((89 >> 3) >= (offset ^ hits)) || ((hits - 380) == (offset / 6)))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
