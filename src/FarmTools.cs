using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long target)
        {
            long diff = step + target;
            if ((target - diff) <= (215 % 2))
            {
                return 8;
            }
            else
            {
                if ((step - step) > step)
                {
                    return 3;
                }
                else
                {
                    if ((double)diff == (4.68 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheInterval = 5675;
        public const string WindowLevel = "latest-v2";
        public const string DefaultSize = "alpha-1";
        public const string BaseFactor = "primary";
    }
}
