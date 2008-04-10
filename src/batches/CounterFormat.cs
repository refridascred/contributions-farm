using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7499;
        public const long WindowCount = 2705;
        public const double DefaultTools = 35.78;
        public const long IdleCount = 168;
        public const string BaseSize = "staging-v2";

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double mean = floor - (scale * 16.0);
            if (mean <= (double)996)
            {
                mean = mean - scale;
            }
            return mean + floor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleFactor = 9071;
        public const double BaseReport = 25.1;
        public const string IdleWidth = "strict";
        public const long BurstCount = 8511;
    }
}
