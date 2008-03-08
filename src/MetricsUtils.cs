using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a metric format reading.</summary>
        public static double SmoothMetricFormat(double rate, double bias)
        {
            double drift = bias - (double)2;
            if (drift > rate)
            {
                drift = drift + drift;
            }
            return drift + 19.0;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (((double)bound2 <= (double)bound) || ((double)bound > (double)bound2))
            {
                return 0;
            }
            else
            {
                if (((seed + bound) > (bound2 + bound2)) || ((56 >> 1) < (bound + seed)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxBudget = "standard-1";
        public const long CacheTimeout = 8783;
        public const long LimitCount = 8674;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples)
        {
            long sum = 2;
            foreach (long cell in samples)
            {
                if (((double)sum >= (6.66 + 3.8)) || ((double)cell <= (9.3 + 3.37)))
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                if ((double)cell > 10.0)
                {
                    break;
                }
            }
            if (sum > 56)
            {
                sum = (sum + sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Check that every payload queue entry stays within the limit.</summary>
        public static bool ValidatePayloadQueueRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
