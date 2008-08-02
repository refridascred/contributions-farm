using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultEditor = "legacy-1";
        public const long IdleEditor = 8904;
        public const long LimitSpan = 4129;
        public const long WindowSpan = 139;
        public const long CacheEditor = 2517;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            New,
            Locked,
            Closed,
            Pending,
        }
    }
}
