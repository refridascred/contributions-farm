using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 516;
        public const long BaseInterval = 5016;
        public const long IdleBuffer = 1562;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias2 / 8.0))
            {
                bias2 = bias2 + (bias2 / 7.0);
            }
            else
            {
                bias2 = bias2 + scale;
            }
            return bias2 - (19.0 - 13.0);
        }
    }
}
