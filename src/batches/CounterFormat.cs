using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate commits stats readings against a bound.</summary>
        public static bool VerifyCommitsStatsLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every githubfarm contributi entry stays within the limit.</summary>
        public static bool GuardGithubfarmContributiRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long IdleBuffer = 9084;
        public const string WindowSize = "latest-edge";
        public const long CacheWidth = 415;
        public const long WindowBuffer = 9303;
    }
}
