using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate channel schema readings against a bound.</summary>
        public static bool ValidateChannelSchemaRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double mean = weight;
            if (mean > (double)(-727))
            {
                mean = mean - (mean * 9.2);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (bias * 14.0);
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Draft,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardScore = 50.9;
        public const long RetrySchema = 4835;
        public const double DefaultSchema = 72.52;
        public const long MaxInterval = 3283;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
