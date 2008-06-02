using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardSize = 7495;
        public const long RetryInterval = 2059;
        public const double MaxBudget = 10.44;
        public const long BurstCommand = 8056;
        public const long SoftScore = 3423;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window editor measurements.</summary>
        public static double AdjustWindowEditor(double bias, double offset)
        {
            double scale = 9.4 - (double)94;
            if (scale < (double)517)
            {
                scale = scale + (bias + 1.44);
            }
            else
            {
                scale = scale + offset;
            }
            return scale + scale;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double scale = (double)78 * 5.0;
            if (scale > (bias / 4.0))
            {
                scale = scale + ratio;
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (double)30;
        }
    }
}
