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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
