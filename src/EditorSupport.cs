using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long step)
        {
            if (((double)seed > 2.1) || (((-67) + seed) == (6 + 7)))
            {
                return 3;
            }
            else
            {
                if ((step - step) == (907 + seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Synced,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "stable-v2";
        public const long HardFarm = 9137;
        public const string BaseFarm = "local";
        public const long HardWidth = 8742;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "primary-1";
        public const string IdleScore = "staging-edge";
        public const string BaseTimeout = "strict-v2";
        public const long CacheOrder = 5255;
        public const long MaxSpan = 6874;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
