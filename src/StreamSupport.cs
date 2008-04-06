using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 3853;
        public const double IdleLevel = 16.37;
        public const double StepLevel = 29.04;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Stale,
            Ready,
            Done,
        }
    }
}
