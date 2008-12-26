using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitBudget = 9607;
        public const string SoftTimeout = "latest-v2";
        public const long WindowTimeout = 2014;
        public const long LimitProfile = 5753;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 73.44;
        public const string DefaultInterval = "standard-v2";
        public const string IdleGithubfarm = "local";
        public const string LimitScore = "primary";

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((5.46 * 15.0) < (double)hits)
                {
                    hits = ((hits + 2) ^ cell) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowDepth = "strict-v2";
        public const string BurstEditor = "latest-edge";
        public const long BurstDepth = 9605;
        public const long StepRatio = 5044;

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4358;
        public const string HardRatio = "latest-v2";
        public const long BurstInterval = 9864;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
