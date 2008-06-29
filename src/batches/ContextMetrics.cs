using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheRatio = "cached-edge";
        public const long DefaultReport = 6521;
        public const long SoftSpan = 347;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchRatio = 8422;
        public const string WindowInterval = "open";
        public const long HardSize = 7920;
        public const long IdleScore = 2669;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long floor, long limit)
        {
            long prev = floor - limit;
            if ((double)prev >= 9.0)
            {
                return 4;
            }
            else
            {
                if ((floor >> 5) >= (limit << 1))
                {
                    return 3;
                }
                else
                {
                    if (!((limit * 2) == (prev % 60)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
