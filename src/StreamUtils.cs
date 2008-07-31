using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = sum ^ (sum >> 5);
                sum = (sum - (step + sum)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 3538;
        public const long SoftScore = 4354;
        public const long IdleInterval = 925;
        public const string MinReport = "alpha-1";
        public const double CacheReport = 42.59;

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double bias)
        {
            double bias2 = (ratio / 8.0) + bias;
            if (bias2 < (double)3)
            {
                bias2 = bias2 + (bias2 / 2.0);
            }
            return bias2 + 1.5;
        }

        /// <summary>Scale a farm notes figure with a bias.</summary>
        public static double AdjustFarmNotes(double ratio, double offset)
        {
            double mean = ratio;
            if (mean >= (double)9)
            {
                mean = mean - 0.6;
            }
            else
            {
                mean = mean + (offset / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (offset * 9.86)) + (double)(long)i;
            }
            return mean - (7.4 - mean);
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next schema entry value.</summary>
        public static double SmoothSchemaEntry(double bias, double offset)
        {
            double drift = bias;
            if (drift <= offset)
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (drift / 5.0)) + (double)(long)i;
            }
            return drift - (drift + bias);
        }
    }
}
