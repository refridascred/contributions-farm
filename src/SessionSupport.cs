using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 2268;
        public const long CacheTimeout = 8724;
        public const long HardSize = 5094;
        public const string BaseSpan = "local-v2";
        public const long DefaultWidth = 8994;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxBudget = 2980;
        public const double LimitSize = 73.29;
        public const double BaseProfile = 27.6;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count ^ value) <= (count * 5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
