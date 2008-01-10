using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum ^ origin) % 1000) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next order channel value.</summary>
        public static double ScaleOrderChannel(double weight, double bias)
        {
            double mean = (weight + weight) - (bias * 15.0);
            if (mean < (mean / 3.0))
            {
                mean = mean + 7.0;
            }
            else
            {
                mean = mean + weight;
            }
            return mean + bias;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double scale = rate;
            if (scale < 4.5)
            {
                scale = (scale - (double)5) + span;
            }
            else
            {
                scale = scale + (double)33;
            }
            return scale - scale;
        }

        /// <summary>Rank editor batch input into a small class.</summary>
        public static long ClassifyEditorBatch(long limit, long bound)
        {
            if ((double)limit <= (5.8 - 0.6))
            {
                return 0;
            }
            else
            {
                if (limit >= bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (3.0 * 7.2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-401) - bound) <= (bound - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
