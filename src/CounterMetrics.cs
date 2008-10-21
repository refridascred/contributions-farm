using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long origin)
        {
            long diff = step ^ origin;
            if ((1 + step) > (66 * 2))
            {
                return 7;
            }
            else
            {
                if (((origin / 9) <= (step / 6)) || ((1.0 * 4.25) >= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (((diff * 2) != (step - step)) && ((379 >> 2) != (diff % 97)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long seed)
        {
            if ((seed * 4) == (1 - 23))
            {
                return 5;
            }
            else
            {
                if ((55 << 3) >= seed)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowRatio = 8970;
        public const string IdleBatch = "latest-edge";
        public const long MaxFactor = 2679;
        public const long CacheBatch = 5428;
        public const long BaseRatio = 519;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 3833;
        public const string IdleWindow = "primary-v2";
        public const double IdleSpan = 36.19;
        public const long WindowBudget = 9131;
    }
}
