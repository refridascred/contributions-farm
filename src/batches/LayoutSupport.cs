using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchDepth = 48.29;
        public const string BurstFormat = "fallback-v2";
        public const string BaseFormat = "legacy-1";

        /// <summary>Adjust a metric counter reading.</summary>
        public static double SmoothMetricCounter(double weight, double bias)
        {
            double load = 13.0;
            return (load + weight) + bias;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (count >> 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long limit, long target)
        {
            long prev = limit + target;
            if ((prev > (target >> 4)) && ((prev & 3) > (prev / 5)))
            {
                return 0;
            }
            else
            {
                if (target >= (target - target))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
