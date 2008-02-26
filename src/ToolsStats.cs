using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = ratio - bias;
            }
            return ratio - 8.9;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "local-v2";
        public const double IdleRatio = 45.73;
        public const double BurstRoute = 3.3;
        public const long BatchRoute = 9708;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double mean = bias;
            if (mean > (7.0 * 5.7))
            {
                mean = (mean - (double)602) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (1.0 - 8.91);
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 9512;
        public const long DefaultAccount = 4740;
        public const long CacheFactor = 3163;
        public const long SoftLevel = 3534;
        public const long BurstAccount = 6510;
    }
}
