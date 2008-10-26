using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally < (limit - 4))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftRatio = 8150;
        public const string LimitBudget = "cached-edge";
        public const long WindowDepth = 7721;
        public const string MinReport = "legacy-1";
        public const string BaseBudget = "local";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Idle,
            Active,
            New,
            Pending,
        }
    }
}
