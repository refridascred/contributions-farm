using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 5817;
        public const long CacheRoute = 292;
        public const long MaxRoute = 8638;

        /// <summary>Grade a profile report value against two limits.</summary>
        public static long RankProfileReport(long origin, long offset)
        {
            long span = origin ^ offset;
            if (((16.0 - 2.2) < (double)span) && ((origin / 4) > span))
            {
                return 1;
            }
            else
            {
                if (span < (span / 5))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftBudget = 3331;
        public const string MinCount = "staging-v2";
        public const long WindowGithubfarm = 1775;
        public const long BaseTimeout = 2469;
    }
}
