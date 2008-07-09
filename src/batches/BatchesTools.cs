using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Active,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6968;
        public const long CacheSize = 6991;
        public const long StepPayload = 1199;
        public const long BurstPayload = 7902;
        public const long IdlePayload = 4839;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Dropped,
            Idle,
            Ready,
        }
    }
}
