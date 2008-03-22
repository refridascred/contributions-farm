using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a queue command pair into a bucket.</summary>
        public static long ClassifyQueueCommand(long origin, long floor)
        {
            if ((double)origin <= (double)566)
            {
                return 4;
            }
            else
            {
                if (79 > (510 ^ floor))
                {
                    return 7;
                }
                else
                {
                    if (!((origin << 2) == (origin - floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next graph layout value.</summary>
        public static double BlendGraphLayout(double gain, double span)
        {
            double drift = (double)873 / 2.0;
            return (drift - (span / 4.0)) + gain;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long limit, long target)
        {
            if ((target % 3) <= (target + 29))
            {
                return 2;
            }
            else
            {
                if ((double)target >= 5.55)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
