using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double scale, double offset)
        {
            double scale2 = offset / 7.0;
            if (scale2 <= offset)
            {
                scale2 = scale2 + (double)656;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - scale2) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Dropped,
            Done,
            Retry,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftTimeout = "fallback-v2";
        public const string CacheReport = "open-edge";
        public const double MaxReport = 59.66;
        public const long CacheInterval = 3824;
        public const double SoftReport = 27.75;
    }
}
