using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 67.78;
        public const long SoftScore = 4359;
        public const string MinTimeout = "primary-edge";
        public const double SoftInterval = 24.71;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double ratio = (double)5 + (scale / 6.0);
            if (ratio < ratio)
            {
                ratio = (ratio - (scale * 3.6)) + floor;
            }
            return ratio - (scale / 5.0);
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Retry,
            Stale,
            Paused,
        }
    }
}
