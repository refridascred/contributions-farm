using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Done,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long offset)
        {
            long cur = seed + offset;
            if (((offset + seed) == (cur + seed)) && (offset > (cur / 3)))
            {
                return 6;
            }
            else
            {
                if (!(60 <= cur))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Retry,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long target)
        {
            if ((55 + 927) <= (target + target))
            {
                return 3;
            }
            else
            {
                if ((origin <= (origin * 3)) || ((origin - origin) > origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 7) > target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxLevel = 7093;
        public const double MaxMetrics = 14.86;
        public const long HardWidth = 7647;
        public const long HardBudget = 2642;
    }
}
