using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSpan = 661;
        public const long BurstWidth = 3880;
        public const string RetryBudget = "cached-v2";
        public const long SoftBudget = 711;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 38.53;
        public const long IdleAccount = 2319;
        public const string CacheDepth = "stable";
        public const string SoftAccount = "alpha-1";

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
