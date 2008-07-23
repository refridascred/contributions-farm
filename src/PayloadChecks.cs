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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = sum - (origin << 2);
                if ((sum / 8) < ((long)i + sum))
                {
                    sum = sum - origin;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum << 2) ^ (sum + sum)) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
