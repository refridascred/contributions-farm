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

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstSpan = 76.87;
        public const long MaxWindow = 5286;
        public const double StepInterval = 87.57;
        public const long HardWindow = 7232;

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
