using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long limit, long limit2)
        {
            long span = limit + limit2;
            if ((span ^ limit) > (9 * 3))
            {
                return 3;
            }
            else
            {
                if ((limit - limit2) == (span - limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 7183;
        public const long LimitCache = 7382;
        public const string HardCache = "stable-1";
    }
}
