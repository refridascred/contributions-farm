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

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Paused,
            Queued,
        }

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
