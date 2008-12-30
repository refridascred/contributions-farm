using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 4886;
        public const double IdleSize = 27.51;
        public const double StepNotes = 87.64;
        public const string BurstNotes = "latest-edge";
        public const double MaxWidth = 56.45;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinCommand = 98.94;
        public const string MaxCommand = "alpha-1";
        public const long RetryCommand = 1921;
    }
}
