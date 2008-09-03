using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (scale * 11.0)) + (double)(long)i) - ratio;
            }
            return scale - 9.2;
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
