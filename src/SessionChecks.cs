using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "primary-v2";
        public const long SoftRatio = 6440;
        public const long BurstToken = 3590;
        public const long WindowCount = 2483;
        public const long LimitBudget = 7741;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((192 ^ 744) <= origin))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
