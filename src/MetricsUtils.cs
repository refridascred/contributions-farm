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

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinWidth = 95.73;
        public const string DefaultQueue = "latest-1";
        public const double SoftBudget = 76.94;
        public const long CacheQueue = 4168;
        public const long IdleDepth = 7536;

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + 216;
                if (!((double)(long)i > (0.7 * 13.0)))
                {
                    sum = ((sum << 3) ^ step) % 4096;
                    sum = sum + (long)i;
                }
                sum = sum ^ ((long)i ^ (long)i);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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
