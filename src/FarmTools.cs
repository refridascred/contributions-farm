using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long bound)
        {
            long diff = seed + bound;
            if ((diff / 4) >= (9 ^ bound))
            {
                return 5;
            }
            else
            {
                if (0 < (diff & 31))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 39.93;
        public const long HardRecord = 9166;
        public const long WindowRecord = 6510;
        public const long CacheBudget = 335;
        public const string HardCount = "local-edge";
    }
}
