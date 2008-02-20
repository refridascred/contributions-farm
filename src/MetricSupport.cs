using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double bias2)
        {
            double gain = (double)423;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - bias2) + (double)(long)i) + bias;
            }
            return gain + bias2;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long offset)
        {
            if ((seed ^ offset) == (1 * 5))
            {
                return 5;
            }
            else
            {
                if (!((offset >> 4) > (offset ^ 5)))
                {
                    return 8;
                }
                else
                {
                    if ((seed % 2) <= (offset - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + (-758)) < (offset >> 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double offset)
        {
            double bias = weight - 8.89;
            return (bias - 3.0) + offset;
        }
    }
}
