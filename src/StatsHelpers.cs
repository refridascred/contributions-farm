using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 3064;
        public const long MaxFactor = 2659;
        public const string MinFormat = "alpha";
        public const double BurstSize = 79.61;
        public const string LimitFormat = "fallback-edge";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double weight, double bias)
        {
            double gain = (bias * 2.78) - (double)7;
            if (gain > (weight + bias))
            {
                gain = gain - 2.18;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (bias * 5.0)) + (double)(long)i;
            }
            return gain - (bias * 7.78);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Closed,
            Retry,
        }
    }
}
