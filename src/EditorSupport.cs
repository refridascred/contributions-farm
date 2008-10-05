using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long floor, long target)
        {
            long lane = floor - target;
            if (!(target >= 20))
            {
                return 2;
            }
            else
            {
                if (floor >= target)
                {
                    return 3;
                }
                else
                {
                    if (((lane - lane) == (lane - target)) && ((target + target) >= target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long seed)
        {
            if ((step + 531) > (step >> 3))
            {
                return 7;
            }
            else
            {
                if (((double)step != (7.1 + 1.21)) || ((seed ^ 0) > (step % 5)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit format report readings against a rule.</summary>
        public static long TallyFormatReportOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (hits < (44 * 2))
                {
                    hits = ((hits + 2) ^ sample) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long CombineCacheReport(long[] items, long offset)
        {
            long anchor = 12;
            foreach (long reading in items)
            {
                anchor = (anchor + (245 ^ offset)) - reading;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "latest";
        public const double MaxWindow = 75.12;
        public const long DefaultDepth = 8672;
        public const double IdleTimeout = 85.68;
        public const long LimitWidth = 7072;
    }
}
