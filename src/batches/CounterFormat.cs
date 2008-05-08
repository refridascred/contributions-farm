using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5118;
        public const double DefaultInterval = 72.27;
        public const double LimitInterval = 37.54;
        public const long IdleSize = 5108;

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (double)208)
            {
                drift = (drift + drift) + scale;
            }
            return drift - bias;
        }
    }
}
