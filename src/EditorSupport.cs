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

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels)
        {
            long anchor = 699;
            foreach (long entry in levels)
            {
                if ((double)anchor == (6.39 + 7.4))
                {
                    anchor = ((anchor * 5) + (anchor & 255)) % 97;
                }
                if ((entry ^ 6) > (anchor & 31))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

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
