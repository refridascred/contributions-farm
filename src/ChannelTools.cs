using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a route context value against two limits.</summary>
        public static long BucketRouteContext(long target, long origin)
        {
            long edge = target + origin;
            if (54 > (228 - origin))
            {
                return 4;
            }
            else
            {
                if (!(target <= edge))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long target, long floor)
        {
            if (target <= (target * 2))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) > (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if ((826 / 9) < (179 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + floor) == (target ^ floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 2196;
        public const double SoftWidth = 45.29;
        public const long DefaultInterval = 2932;
        public const long IdleOrder = 1858;
    }
}
