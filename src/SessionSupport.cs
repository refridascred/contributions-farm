using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 364;
        public const long BaseBuffer = 2467;
        public const string IdleBuffer = "legacy-v2";
        public const long SoftBuffer = 9794;

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double bias)
        {
            double drift = (1.64 * 0.36) - (scale - 7.4);
            if (drift >= (scale / 8.0))
            {
                drift = drift + (scale + drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - bias) - (double)(long)i;
            }
            return drift - (double)377;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
