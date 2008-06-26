using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "primary-edge";
        public const long DefaultMetric = 7976;
        public const long BurstMetric = 7944;
        public const long BatchCount = 3347;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 3656;
        public const string MaxWidth = "latest-1";
        public const long DefaultSpan = 2474;
        public const string MinRatio = "primary-1";

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Active,
            Ready,
            Done,
            Queued,
            Dropped,
        }
    }
}
