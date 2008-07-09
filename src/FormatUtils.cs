using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double rate2 = (double)(9 << 2);
            if (rate2 > 6.03)
            {
                rate2 = (rate2 + rate2) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 + (rate * 9.2);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardBudget = 4316;
        public const double LimitReport = 9.63;
        public const string BurstReport = "staging-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCount = 4102;
        public const string HardCluster = "cached-v2";
        public const long DefaultCluster = 2243;
        public const long DefaultFactor = 6926;

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 5860;
        public const string WindowRatio = "standard-1";
        public const long LimitSize = 1572;
        public const long SoftInterval = 5966;
        public const string RetryStream = "latest-edge";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double bias = 2.88;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias + (bias + bias)) + (double)(long)i) - scale) + offset;
            }
            return bias + (double)91;
        }
    }
}
