using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseMetrics = "open";
        public const string LimitMetrics = "local";
        public const double CacheMetrics = 10.91;

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
