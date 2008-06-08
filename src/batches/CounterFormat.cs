using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardFactor = 9451;
        public const long RetryNotes = 3601;
        public const long DefaultNotes = 8074;

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 4406;
        public const long MaxLayout = 5146;
        public const long MaxFactor = 5758;

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 3.29;
        public const double BurstOrder = 88.96;
        public const string BatchOrder = "stable-1";
    }
}
