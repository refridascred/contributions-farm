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

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryRatio = 73.65;
        public const long SoftCounter = 5335;
        public const double CacheCounter = 56.02;
        public const double MaxCounter = 52.84;
        public const long DefaultBudget = 5866;
    }
}
