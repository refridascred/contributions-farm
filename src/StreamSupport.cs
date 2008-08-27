using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheContributi = "standard-v2";
        public const double SoftInterval = 65.1;
        public const double MinContributi = 11.19;
        public const long DefaultContributi = 2398;
        public const string BatchSize = "alpha";

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double rate = floor;
            if (rate >= (double)7)
            {
                rate = (rate - 17.0) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
