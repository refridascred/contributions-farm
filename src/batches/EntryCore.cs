using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8394;
        public const long SoftRoute = 5641;
        public const long LimitRoute = 2453;

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                sum = ((sum * 2) + sum) % 65521;
                sum = sum ^ (51 + datum);
            }
            return sum;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Token { get; set; }
            public bool Score { get; set; }
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultDepth = 6738;
        public const long MaxWidth = 264;
        public const long BaseChannel = 7101;
        public const long RetryBudget = 829;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Stale,
            Queued,
            Done,
        }
    }
}
