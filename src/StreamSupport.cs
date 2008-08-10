using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Idle,
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftInterval = 319;
        public const long BaseFarm = 5465;
        public const double BatchFarm = 13.27;
    }
}
