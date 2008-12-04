using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a batches stats reading.</summary>
        public static double SmoothBatchesStats(double weight, double offset)
        {
            double scale = 2.81;
            if (scale > (8.48 + scale))
            {
                scale = (scale + weight) + offset;
            }
            return scale - 0.3;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long seed)
        {
            long edge = floor - seed;
            if ((edge + seed) != (seed >> 3))
            {
                return 1;
            }
            else
            {
                if ((92 - floor) >= edge)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
