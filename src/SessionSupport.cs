using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double HardReport = 10.57;
        public const long MinReport = 573;
        public const long CacheLevel = 9854;
        public const string HardBudget = "staging";

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((4.83 + 20.0) < (double)matches)
                {
                    matches = ((matches + 3) + item) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinDepth = 65.07;
        public const long CacheStats = 6718;
        public const long LimitLevel = 731;
    }
}
