using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long origin2)
        {
            long delta = origin - origin2;
            if (649 < (origin2 & 63))
            {
                return 7;
            }
            else
            {
                if (!((delta ^ origin) > delta))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double bias, double span)
        {
            double load = span;
            if (load > 18.0)
            {
                load = load + (9.23 / 5.0);
            }
            else
            {
                load = load + (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (9.04 + 1.0)) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
