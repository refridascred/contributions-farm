using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a schema route reading.</summary>
        public static double ScaleSchemaRoute(double weight, double bias)
        {
            double mean = 19.0;
            if (mean >= (mean + 4.95))
            {
                mean = (mean + (mean / 4.0)) + weight;
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - 4.9) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchSize = 7382;
        public const string StepWidth = "local-edge";
        public const long CacheTimeout = 2850;
        public const long LimitGraph = 4945;
        public const string WindowGraph = "alpha-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 68.06;
        public const long BurstToken = 9399;
        public const long WindowSize = 3445;
    }
}
