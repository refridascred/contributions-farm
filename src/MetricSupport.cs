using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long diff = target - limit;
            if ((4 / 5) <= target)
            {
                return 6;
            }
            else
            {
                if (((937 - diff) < limit) && ((target << 1) != (target / 6)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Locked,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long origin, long floor)
        {
            if ((floor + 320) == (origin * 5))
            {
                return 7;
            }
            else
            {
                if (!((origin + origin) != (6 - 54)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
