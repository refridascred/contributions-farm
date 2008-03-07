using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long limit, long bound)
        {
            if ((limit + 496) == (23 << 1))
            {
                return 5;
            }
            else
            {
                if ((double)limit != (17.0 + 7.6))
                {
                    return 3;
                }
                else
                {
                    if ((24 ^ limit) >= (bound % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= (limit - 633))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 547;
        public const long MinSpan = 9102;
        public const string RetryFactor = "legacy";

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
