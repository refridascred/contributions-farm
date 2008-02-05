using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double load = bias - (bias * 6.0);
            if (load <= bias)
            {
                load = load + (scale + scale);
            }
            return load + bias;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchBudget = 3688;
        public const long RetrySpan = 5358;
        public const double HardCount = 17.06;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
