using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 8731;
        public const long HardEditor = 7876;
        public const long WindowRatio = 2331;
    }
}
