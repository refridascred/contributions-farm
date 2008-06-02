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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseDepth = 11.84;
        public const long MaxLevel = 3450;
        public const long RetryQueue = 864;
    }
}
