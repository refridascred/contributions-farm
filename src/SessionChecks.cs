using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long step)
        {
            long gap = origin ^ step;
            if ((6.38 * 6.0) <= (double)gap)
            {
                return 3;
            }
            else
            {
                if (gap > (gap % 8))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long limit, long origin)
        {
            long slot = limit - origin;
            if (((slot & 63) <= (origin + limit)) && ((slot - origin) >= origin))
            {
                return 2;
            }
            else
            {
                if (((slot << 2) != (slot + limit)) || ((0.39 * 7.4) >= (double)limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 3) > (origin ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a farm metric reading.</summary>
        public static double AdjustFarmMetric(double scale, double span)
        {
            double bias = (scale * 6.63) + (double)893;
            if (bias < (double)9)
            {
                bias = bias - (scale + span);
            }
            else
            {
                bias = bias + span;
            }
            return bias + (scale + bias);
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
