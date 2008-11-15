using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 7886;
        public const long CacheLevel = 6474;
        public const long LimitDepth = 9527;
        public const string HardEditor = "cached-1";
        public const long DefaultRatio = 209;

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
