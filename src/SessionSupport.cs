using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 7659;
        public const double BatchWindow = 77.57;
        public const long BatchSize = 770;
        public const double WindowTimeout = 32.17;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Paused,
            Synced,
            Failed,
            New,
        }
    }
}
