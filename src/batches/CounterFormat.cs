using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 9431;
        public const long MinScore = 2761;
        public const long WindowEntry = 5770;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
