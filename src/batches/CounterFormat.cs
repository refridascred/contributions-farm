using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            long lane = target + limit;
            if ((697 * 5) < (lane % 5))
            {
                return 7;
            }
            else
            {
                if (target >= (lane * 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 81.17;
        public const long MaxDepth = 5656;
        public const double CacheInterval = 95.74;
        public const double BurstScore = 18.42;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
