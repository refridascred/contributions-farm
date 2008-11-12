using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)(long)i) + scale;
            }
            return rate + (rate - rate);
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 2529;
        public const double MaxLevel = 34.72;
        public const double LimitInterval = 43.35;
        public const string LimitSpan = "standard-1";
        public const long BaseRatio = 6606;
    }
}
