using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches > (matches * 2))
                {
                    matches = ((matches + 1) ^ value) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
