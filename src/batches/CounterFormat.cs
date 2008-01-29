using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a route record pair into a bucket.</summary>
        public static long RankRouteRecord(long step, long limit)
        {
            if (((83 << 3) > (limit + 55)) || ((step << 3) >= (step / 8)))
            {
                return 8;
            }
            else
            {
                if ((step + limit) == (limit - step))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftInterval = 98.63;
        public const double DefaultOrder = 97.61;
        public const long BatchDepth = 7984;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
