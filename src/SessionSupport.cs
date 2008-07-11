using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double bias)
        {
            double drift = weight;
            if (drift > 1.17)
            {
                drift = drift - (weight / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long limit, long bound)
        {
            if (295 <= (bound + bound))
            {
                return 4;
            }
            else
            {
                if ((652 < (limit - bound)) && ((double)4 <= (7.78 * 6.92)))
                {
                    return 6;
                }
                else
                {
                    if ((limit + bound) < (30 & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
