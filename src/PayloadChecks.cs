using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double mean = 4.8;
            if (mean <= (double)2)
            {
                mean = mean - 11.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (0.23 + gain)) + (double)(long)i;
            }
            return mean - (offset * 1.3);
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long target)
        {
            long span = limit - target;
            if ((double)limit != (8.3 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((6.4 - 6.32) > (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a window graph figure with a bias.</summary>
        public static double SmoothWindowGraph(double ratio, double bias)
        {
            double scale = (bias + 4.5) - ratio;
            return scale - 10.0;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits % 16) >= (hits >> 3))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long bound, long target)
        {
            if ((target + target) == (3 / 4))
            {
                return 4;
            }
            else
            {
                if (!(bound < 0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] series)
        {
            long mix = 909;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (mix >> 4)) ^ datum;
            }
            return mix % 1000;
        }
    }
}
