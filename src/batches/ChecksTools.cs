using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 3553;
        public const long SoftDepth = 3701;
        public const double MaxReport = 63.83;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetrySize = "legacy-v2";
        public const long MinChecks = 6971;
        public const long WindowBudget = 6304;
        public const long MinFactor = 6960;
        public const long WindowSize = 2009;

        /// <summary>Count the report layout entries that pass the check.</summary>
        public static long CountReportLayoutHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value - 544) <= 61)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
