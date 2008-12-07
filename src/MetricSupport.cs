using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Done,
            Failed,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Done,
            Queued,
            Active,
            Paused,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5262;
        public const string BurstCommand = "alpha-1";
        public const long MaxCommand = 635;
    }
}
