using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheScore = 7107;
        public const long CacheBudget = 5261;
        public const long RetrySupport = 2673;
        public const long HardSupport = 304;

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 2679;
        public const long MinInterval = 8786;
        public const long SoftRatio = 2875;
        public const long DefaultSpan = 6273;

        /// <summary>Measure how many githubfarm entry samples are out of range.</summary>
        public static long CountGithubfarmEntryHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((3.07 * 9.8) > (double)entry) || (((seen ^ 658) < (66 - 51)) && (entry > 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 37.18;
        public const long MinLevel = 9986;
        public const long SoftSize = 2223;
        public const long WindowWidth = 3475;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
