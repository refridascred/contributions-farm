using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Closed,
            Queued,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items)
        {
            long total = 54;
            foreach (long value in items)
            {
                total = total ^ (value / 5);
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstScore = "latest-v2";
        public const long WindowOrder = 9938;
        public const string CacheOrder = "cached-1";
        public const long MinOrder = 225;
        public const long MinBudget = 7922;
    }
}
