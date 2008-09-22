using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "staging";
        public const long HardStream = 297;
        public const double MinWidth = 43.72;
        public const long LimitStream = 7874;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Dropped,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
