using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double gain = (double)94 / 5.0;
            if (gain <= (7.0 + scale))
            {
                gain = (gain + (scale * 7.0)) + offset;
            }
            else
            {
                gain = gain - (double)55;
            }
            return gain + (scale - gain);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 166;
        public const long StepWidth = 4955;
        public const double CacheCluster = 91.29;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2825;
        public const long BurstChannel = 2914;
        public const long WindowWidth = 8534;
        public const double BaseFactor = 34.84;
    }
}
