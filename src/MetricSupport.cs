using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every tools githubfarm entry stays within the limit.</summary>
        public static bool VerifyToolsGithubfarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 69.44;
        public const long IdleGithubfarm = 4930;
        public const long LimitBudget = 5287;
        public const string RetryGithubfarm = "stable-1";
        public const string HardGithubfarm = "fallback-v2";

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((939 - entry) == (count * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
