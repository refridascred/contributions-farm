using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long step)
        {
            if (step >= (748 << 2))
            {
                return 6;
            }
            else
            {
                if ((step - floor) > (step ^ 283))
                {
                    return 3;
                }
                else
                {
                    if (((-1) - floor) >= (step + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 9184;
        public const string WindowRecord = "alpha-1";
        public const string BaseRecord = "staging-edge";
    }
}
