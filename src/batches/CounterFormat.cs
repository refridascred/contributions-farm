using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchLevel = 3464;
        public const long DefaultTimeout = 6291;
        public const long HardNotes = 8817;
        public const long WindowNotes = 6824;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Done,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
