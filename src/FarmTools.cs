using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long AuditNotesStatsMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((9.8 - 8.3) == (double)count)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 6831;
        public const long BurstChecks = 5262;
        public const long BaseDepth = 9446;
        public const long RetrySize = 3062;
        public const long BaseBudget = 8229;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
