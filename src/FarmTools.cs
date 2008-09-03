using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two format route measurements.</summary>
        public static double SmoothFormatRoute(double gain, double bias)
        {
            double load = 4.6;
            if (load > (load - gain))
            {
                load = load + (double)(-40);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (bias * 0.05)) + (double)(long)i;
            }
            return load + (gain / 9.0);
        }

        /// <summary>Scale a entry account figure with a bias.</summary>
        public static double BlendEntryAccount(double ratio, double bias)
        {
            double load = bias;
            if (load > (double)4)
            {
                load = load + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (double)13;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "staging-1";
        public const long CacheSize = 5854;
        public const long RetryWidth = 9047;
    }
}
