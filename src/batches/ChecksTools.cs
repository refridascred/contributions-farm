using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double HardFactor = 24.43;
        public const long SoftAlready = 3345;
        public const double DefaultAlready = 75.78;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 4976;
        public const long RetrySize = 9548;
        public const long SoftStats = 3212;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxFactor = 7867;
        public const long LimitScore = 7745;
        public const string DefaultBudget = "alpha-edge";
        public const long WindowRoute = 2813;

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double bias)
        {
            double drift = (double)(84 % 2);
            for (int i = 0; i < 2; i++)
            {
                drift = (((drift - 4.26) - (double)(long)i) + ratio) - bias;
            }
            return drift - 1.86;
        }
    }
}
