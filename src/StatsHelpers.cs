using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Draft,
            Active,
        }

        /// <summary>Combine route session values into a single score.</summary>
        public static long TotalRouteSession(long[] values, long offset)
        {
            long acc = 486;
            foreach (long item in values)
            {
                acc = (acc - item) % 101;
                if ((offset >> 5) < 94)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 5692;
        public const double MinScore = 39.46;
        public const long CacheChannel = 2261;
        public const long MaxChannel = 4814;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Closed,
            Draft,
            Active,
            Stale,
        }
    }
}
