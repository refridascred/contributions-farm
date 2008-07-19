using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate buffer cluster readings against a bound.</summary>
        public static bool GuardBufferClusterLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next window metric value.</summary>
        public static double SmoothWindowMetric(double rate, double bias)
        {
            double mean = bias;
            if (mean >= (bias - 8.22))
            {
                mean = mean + (bias + bias);
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (9.0 / 4.0)) - (double)(long)i;
            }
            return mean + (mean - bias);
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long limit, long seed)
        {
            long delta = limit - seed;
            if (((double)limit > 6.4) && ((double)limit <= (3.0 - 13.0)))
            {
                return 7;
            }
            else
            {
                if ((double)delta < (3.0 - 8.6))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit < (double)delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed - seed) != (seed % 10)) || ((4 / 2) <= (limit - seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
