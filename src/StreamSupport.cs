using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheScore = 2066;
        public const double IdleBudget = 83.65;
        public const long StepWidth = 7207;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
