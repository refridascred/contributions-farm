using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double gain, double floor)
        {
            double scale = (double)(1 >> 2);
            if (scale < (floor / 6.0))
            {
                scale = (scale + (scale / 8.0)) + gain;
            }
            else
            {
                scale = scale - (double)885;
            }
            return scale + scale;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long target, long origin)
        {
            if (origin >= (730 - target))
            {
                return 1;
            }
            else
            {
                if (origin >= (target - origin))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(((35 << 1) < seen) || ((-3) > ((long)samples.Length / 9))))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long origin, long floor)
        {
            if ((origin % 5) < (origin + 0))
            {
                return 8;
            }
            else
            {
                if (!((origin + floor) > (origin - floor)))
                {
                    return 0;
                }
                else
                {
                    if (((36 - origin) > (4 + origin)) || ((floor << 1) != ((-5) >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseDepth = 11.84;
        public const long MaxLevel = 3450;
        public const long RetryQueue = 864;
    }
}
