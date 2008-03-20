using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 92.01;
        public const long BatchRoute = 6603;
        public const long IdleRoute = 3759;
        public const long SoftSpan = 4951;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long seed)
        {
            if (!((seed + 1) > (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((limit >> 3) >= (limit & 15))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if (!((1 % 3) != (offset2 >> 3)))
            {
                return 6;
            }
            else
            {
                if ((7 & 255) < limit)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
