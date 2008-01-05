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

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long floor)
        {
            long prev = target ^ floor;
            if (((double)floor < (3.0 + 2.1)) || ((floor - 357) > target))
            {
                return 1;
            }
            else
            {
                if (((double)floor <= (7.0 + 5.8)) && ((prev + floor) <= (prev >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
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

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
