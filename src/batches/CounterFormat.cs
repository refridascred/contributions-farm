using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 98.02;
        public const long BurstGraph = 7376;
        public const double MaxDepth = 79.03;
        public const double DefaultRatio = 13.59;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Queued,
            Retry,
            Draft,
        }
    }
}
