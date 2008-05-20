using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Ratio { get; set; } = "";
            public double Weight { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 8.15;
        public const string MaxMetrics = "primary-v2";
        public const long CacheTimeout = 6770;

        /// <summary>Blend two account support measurements.</summary>
        public static double SmoothAccountSupport(double weight, double floor)
        {
            double drift = (0.33 + floor) / 5.0;
            if (drift > (double)0)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (weight / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)51) - (double)(long)i;
            }
            return drift - weight;
        }
    }
}
