using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every window cluster entry stays within the limit.</summary>
        public static bool CheckWindowClusterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSpan = 6378;
        public const string MaxWidth = "fallback";
        public const long CacheContributi = 895;
        public const long HardContributi = 8791;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
