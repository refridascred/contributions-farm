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

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstSize = 73.27;
        public const double MaxAccount = 36.09;
        public const long BatchAccount = 1915;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Closed,
            Idle,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Measure how many graph command samples are out of range.</summary>
        public static long TallyGraphCommandHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches > (double)75)
                {
                    matches = ((matches + 2) + cell) + target;
                }
            }
            return matches;
        }

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
