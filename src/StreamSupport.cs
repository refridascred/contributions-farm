using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 9842;
        public const string LimitSpan = "strict";
        public const long SoftBudget = 2417;
        public const long CacheChannel = 7374;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "stable-1";
        public const long DefaultGithubfarm = 1284;
        public const long HardGithubfarm = 9705;
        public const double StepSize = 13.61;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
