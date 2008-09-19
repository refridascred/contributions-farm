using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank stream route input into a small class.</summary>
        public static long RankStreamRoute(long floor, long step)
        {
            if (!(step > (floor - 159)))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= 3.1)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit batch cache readings against a rule.</summary>
        public static long CountBatchCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample % 97) <= (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 7200;
        public const long IdleGithubfarm = 7249;
        public const long MinRatio = 4785;
        public const string CacheLevel = "primary-v2";
        public const long BaseCount = 5234;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 4851;
        public const long SoftLayout = 1597;
        public const long WindowLayout = 968;
        public const long LimitLevel = 2145;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Ready,
            Done,
            Queued,
        }
    }
}
