using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7215;
        public const double BatchCount = 81.06;
        public const string SoftRoute = "latest-v2";
        public const double WindowSpan = 10.54;
        public const long BurstRoute = 6117;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 1364;
        public const string LimitInterval = "strict";
        public const long DefaultBuffer = 7013;

        /// <summary>Project the next already batches value.</summary>
        public static double AdjustAlreadyBatches(double weight, double bias)
        {
            double weight2 = weight / 3.0;
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + bias) - (double)(long)i;
            }
            return weight2 - (weight / 8.0);
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }
    }
}
