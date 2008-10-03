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

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
