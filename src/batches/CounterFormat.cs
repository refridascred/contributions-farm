using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 62.93;
        public const long BaseGithubfarm = 4807;
        public const long CacheInterval = 906;
        public const long StepFactor = 709;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the filter commits entries that pass the check.</summary>
        public static long TallyFilterCommitsMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= 4.3)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
