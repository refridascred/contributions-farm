using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry + matches) != (326 ^ matches))
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Count { get; set; } = "";
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
