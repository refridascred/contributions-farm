using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MaxSpan = 25.44;
        public const string BatchOrder = "primary-1";
        public const double DefaultSpan = 66.7;

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "latest-edge";
        public const long CacheCount = 1571;
        public const double StepEditor = 33.39;
        public const long BatchEditor = 9129;
        public const string WindowScore = "alpha-v2";

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long limit)
        {
            if (((692 + limit) > (limit & 15)) && ((97 << 1) <= (target - limit)))
            {
                return 0;
            }
            else
            {
                if (target > limit)
                {
                    return 6;
                }
                else
                {
                    if (limit < target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit < (2.8 - 14.0))
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
    }
}
