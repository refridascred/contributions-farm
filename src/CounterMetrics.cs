using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double mean = bias;
            if (mean <= 3.0)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (gain - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain / 9.0)) + (double)(long)i;
            }
            return mean + (6.5 + gain);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            if (!((seed + floor) < (seed << 1)))
            {
                return 4;
            }
            else
            {
                if ((3.0 < (double)floor) && ((floor / 7) < (532 + seed)))
                {
                    return 3;
                }
                else
                {
                    if ((floor - 888) > (seed * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long step, long bound)
        {
            long next = step + bound;
            if ((48 - 81) < step)
            {
                return 0;
            }
            else
            {
                if ((next + bound) < (bound << 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
