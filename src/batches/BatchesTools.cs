using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double gain, double span)
        {
            double weight = span;
            if (weight >= (double)47)
            {
                weight = (weight + 5.8) + gain;
            }
            return weight - (double)(-36);
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long limit)
        {
            long gap = target + limit;
            if ((limit ^ target) > gap)
            {
                return 0;
            }
            else
            {
                if (((limit & 255) <= (limit + limit)) && ((target >> 4) == ((-42) & 15)))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 2) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.42 / 7.0) != (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
