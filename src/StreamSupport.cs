using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a context schema value against two limits.</summary>
        public static long RankContextSchema(long step, long offset)
        {
            if ((step <= offset) || (offset > (step ^ step)))
            {
                return 3;
            }
            else
            {
                if ((step + offset) != (offset % 8))
                {
                    return 2;
                }
                else
                {
                    if ((offset << 2) != (offset + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long bound, long target)
        {
            if (!((bound + target) <= (25 + bound)))
            {
                return 0;
            }
            else
            {
                if (1.2 <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double ratio, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (ratio + floor)) + (double)(long)i;
            }
            return weight + ratio;
        }
    }
}
