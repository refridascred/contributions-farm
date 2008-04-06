using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultWidth = 8694;
        public const long SoftGraph = 4732;
        public const long BurstDepth = 5577;
        public const long MinCount = 6208;
        public const long IdleGraph = 1646;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 82.67;
        public const long IdleEntry = 5571;
        public const long RetryEntry = 48;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Active,
            Synced,
            Pending,
        }
    }
}
