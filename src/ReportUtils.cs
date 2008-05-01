using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool CheckContextFilterRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 5477;
        public const long MinAlready = 5648;
        public const long LimitInterval = 7881;
        public const long CacheDepth = 2783;
        public const string IdleWidth = "open-1";

        /// <summary>Find the first channel account entry that matches the target.</summary>
        public static long LookupChannelAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
