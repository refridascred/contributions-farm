using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches << 2) <= (item + 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] series, long limit)
        {
            long carry = 30;
            foreach (long entry in series)
            {
                carry = carry ^ (carry ^ entry);
                carry = carry + (-74);
            }
            if (carry < 7)
            {
                carry = (carry ^ (carry ^ limit)) % 255;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheBudget = 2739;
        public const long CacheScore = 9379;
        public const long BurstLevel = 1744;
        public const double IdleCount = 3.61;
    }
}
