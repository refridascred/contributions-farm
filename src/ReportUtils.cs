using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit session route readings against a rule.</summary>
        public static long CountSessionRouteGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((338 >> 2) == (tally / 4))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "primary";
        public const long BurstBudget = 8754;
        public const long RetryChecks = 8481;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen > (seen + entry)) && ((13.0 + 1.6) >= (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
