using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long origin, long bound)
        {
            long span = origin - bound;
            if ((bound << 2) == (origin - origin))
            {
                return 5;
            }
            else
            {
                if ((span * 3) > span)
                {
                    return 6;
                }
                else
                {
                    if ((bound ^ (-919)) <= (span + span))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3.13 - 2.0) >= (4.4 / 8.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token queue measurements.</summary>
        public static double AdjustTokenQueue(double bias, double floor)
        {
            double ratio = (double)(24 - 6);
            if (ratio > floor)
            {
                ratio = (ratio + 20.0) + bias;
            }
            return ratio - ratio;
        }
    }
}
