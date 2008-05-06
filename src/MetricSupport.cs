using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstSpan = 6158;
        public const double IdleCount = 48.58;
        public const long CacheAccount = 1909;
        public const double StepRatio = 26.83;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardSpan = 7396;
        public const string MaxBatches = "primary-1";
        public const string IdleBatches = "stable";
        public const string BatchWidth = "latest-edge";

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Failed,
            Closed,
        }
    }
}
