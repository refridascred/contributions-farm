using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 14.21;
        public const double RetrySize = 97.51;
        public const long BatchFarm = 2927;
        public const long BaseCount = 7913;
        public const double MaxLevel = 8.65;

        /// <summary>Find the first counter report entry that matches the target.</summary>
        public static long LocateCounterReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + (double)(-6);
        }

        /// <summary>Blend two queue schema measurements.</summary>
        public static double AdjustQueueSchema(double ratio, double bias)
        {
            double mean = (double)9 * 6.0;
            if (mean >= (bias + mean))
            {
                mean = (mean + (bias + mean)) - ratio;
            }
            return mean + (double)390;
        }
    }
}
