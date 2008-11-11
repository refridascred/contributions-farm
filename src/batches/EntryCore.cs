using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((long)samples.Length + entry) != (entry ^ entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
