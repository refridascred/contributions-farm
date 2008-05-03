using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit counter stream readings against a rule.</summary>
        public static long CountCounterStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((9 & 1) >= (matches + matches))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            New,
            Failed,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "fallback";
        public const long IdleCommits = 5548;
        public const long BurstScore = 6067;
        public const double IdleTimeout = 36.4;
    }
}
