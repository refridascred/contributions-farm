using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a filter profile pair into a bucket.</summary>
        public static long GradeFilterProfile(long limit, long target)
        {
            if ((85 / 7) <= (target - target))
            {
                return 1;
            }
            else
            {
                if (((target >> 2) >= (target ^ target)) && ((limit ^ target) <= limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit + target) != (998 * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-4) + limit) >= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double weight = floor / 5.0;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (double)60) + (double)(long)i) - ratio;
            }
            return weight - floor;
        }
    }
}
