using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > 5.28)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinLevel = "local";
        public const long BurstBudget = 8371;
        public const long LimitCluster = 7727;
        public const long LimitFactor = 7873;
        public const double CacheTimeout = 65.48;
    }
}
