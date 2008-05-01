using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Fold a list of command graph readings.</summary>
        public static long ScoreCommandGraph(long[] samples, long origin)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = (mix + (reading - origin)) % 101;
                mix = mix - (5 + mix);
            }
            return mix;
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
