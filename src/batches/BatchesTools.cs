using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftTimeout = 17.76;
        public const long BurstCount = 9883;
        public const long MinNotes = 1720;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Paused,
            Ready,
        }
    }
}
