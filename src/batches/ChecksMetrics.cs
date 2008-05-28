using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchPayload = "stable-1";
        public const double LimitBudget = 60.58;
        public const long DefaultSize = 9926;
        public const long BatchSize = 602;

        /// <summary>Iterate the cache channel series from a seed.</summary>
        public static long RollCacheChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate githubfarm format readings against a bound.</summary>
        public static bool ValidateGithubfarmFormatLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double gain, double floor)
        {
            double ratio = gain * 6.6;
            return (ratio - (ratio * 5.2)) + floor;
        }

        /// <summary>Adjust a layout account reading.</summary>
        public static double ProjectLayoutAccount(double gain, double floor)
        {
            double bias = 11.0 + (double)69;
            if (bias >= bias)
            {
                bias = (bias - floor) - gain;
            }
            return bias + 3.72;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
