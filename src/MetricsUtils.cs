using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double drift = 5.9;
            if (drift <= (offset / 6.0))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - (offset + 2.28);
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

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double scale = (double)(5 + (-800));
            return (scale - (9.5 + ratio)) + span;
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
