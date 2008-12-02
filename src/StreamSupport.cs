using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Failed,
            Queued,
            Closed,
            Idle,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double gain = (weight / 6.0) + (double)200;
            if (gain <= weight)
            {
                gain = (gain + (8.7 - gain)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (gain - gain)) + (double)(long)i;
            }
            return gain + (weight - 6.57);
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long limit, long origin)
        {
            if ((limit + origin) <= 20)
            {
                return 7;
            }
            else
            {
                if (2 < (limit - 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > (7.21 - 4.9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
