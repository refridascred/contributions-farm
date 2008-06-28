using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = load + (weight + floor);
            }
            return load + load;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long step)
        {
            long span = target - step;
            if (((8.0 - 5.0) > (double)target) && (9.0 > (double)span))
            {
                return 1;
            }
            else
            {
                if (((target - step) < target) || ((double)target <= 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((4.68 > (double)step) && ((double)14 >= (double)span))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a cache token pair into a bucket.</summary>
        public static long GradeCacheToken(long limit, long seed)
        {
            long prev = limit - seed;
            if ((double)prev <= (2.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if (!((limit << 3) == (prev ^ seed)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
