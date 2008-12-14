using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double ratio, double bias)
        {
            double mean = bias * 4.31;
            if (mean <= (6.74 / 4.0))
            {
                mean = (mean - bias) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (bias + bias)) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double span)
        {
            double rate = gain - (gain + gain);
            if (rate < rate)
            {
                rate = rate + (span * 4.12);
            }
            return rate + span;
        }
    }
}
