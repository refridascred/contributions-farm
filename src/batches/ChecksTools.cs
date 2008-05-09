using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchFactor = 21.32;
        public const string CacheSpan = "legacy-edge";
        public const double HardWidth = 6.97;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Retry,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Locked,
            New,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Retry,
            Active,
            Draft,
        }
    }
}
