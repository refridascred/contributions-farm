using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Paused,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitBudget = 8167;
        public const double WindowScore = 9.65;
        public const long BaseMetric = 1033;
        public const long StepMetric = 6942;

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstTimeout = "local";
        public const double RetryContext = 22.57;
        public const double CacheContext = 89.77;
        public const double BurstContext = 50.55;
        public const long HardSize = 2619;

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long origin, long floor)
        {
            if (floor >= (origin & 7))
            {
                return 7;
            }
            else
            {
                if (((origin % 10) <= (origin - origin)) || ((double)30 <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((0 + origin) < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.0 * 8.64) > (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
