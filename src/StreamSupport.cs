using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate layout metric readings against a bound.</summary>
        public static bool CheckLayoutMetricRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            if ((bound < (step / 9)) || ((267 - step) > (step % 60)))
            {
                return 4;
            }
            else
            {
                if ((bound - bound) < (step - 0))
                {
                    return 7;
                }
                else
                {
                    if (((4.6 + 7.54) != (double)bound) && ((bound ^ 146) > (step + 82)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double bias2 = bias;
            return (bias2 - (bias2 - bias2)) + ratio;
        }
    }
}
