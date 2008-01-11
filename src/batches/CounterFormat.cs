using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 7627;
        public const long StepStream = 4922;
        public const long HardDepth = 9998;
        public const long BaseInterval = 3292;
        public const string CacheStream = "latest-v2";

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double weight, double bias)
        {
            double scale = (double)(375 * 4);
            if (scale < bias)
            {
                scale = scale + (9.24 / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 8.6) + (double)(long)i;
            }
            return scale + weight;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Owner { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
