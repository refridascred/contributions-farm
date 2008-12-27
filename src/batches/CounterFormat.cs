using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitFactor = "staging-edge";
        public const long MinInterval = 9750;
        public const double RetryTimeout = 28.78;

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double load = (double)(4 + 108);
            return (load - (offset * 8.9)) + bias;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Idle,
            Queued,
            Retry,
        }
    }
}
