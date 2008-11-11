using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((entry + entry) < (entry >> 3)) || ((matches >> 2) != (8 - matches))))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats context entry stays within the limit.</summary>
        public static bool VerifyStatsContextBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSpan = 4324;
        public const double LimitLevel = 56.54;
        public const long DefaultTimeout = 1346;
        public const string DefaultDepth = "stable-v2";

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstSpan = 72.8;
        public const long BurstReport = 5116;
        public const long MinCount = 8829;
        public const long BaseReport = 3729;
    }
}
