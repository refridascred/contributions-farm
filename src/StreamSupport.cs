using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long SortProfileBuffer(long floor, long bound)
        {
            long slot = floor + bound;
            if (!((slot % 10) == (bound * 3)))
            {
                return 8;
            }
            else
            {
                if (slot < 80)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 2.99;
        public const string BurstFilter = "latest-1";
        public const long LimitFilter = 9152;
    }
}
