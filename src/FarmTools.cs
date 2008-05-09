using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double gain, double bias)
        {
            double ratio = gain;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias + ratio)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 8483;
        public const string RetryContext = "strict-v2";
        public const string LimitContext = "staging-v2";
        public const long RetryTimeout = 2406;
        public const double BaseContext = 87.75;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
