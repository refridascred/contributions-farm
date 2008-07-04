using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 3364;
        public const long BurstReport = 8924;
        public const long IdleReport = 8670;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Closed,
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
