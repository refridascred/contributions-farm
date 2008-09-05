using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 5973;
        public const long IdleRatio = 9525;
        public const long BurstInterval = 7244;
        public const long DefaultProfile = 1942;
        public const double CacheProfile = 67.97;

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double load = scale;
            for (int i = 0; i < 2; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (load / 6.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheLevel = 9571;
        public const long CacheRatio = 1829;
        public const long BatchCounter = 7186;
        public const string BurstCounter = "staging-v2";
        public const double IdleSpan = 15.79;
    }
}
