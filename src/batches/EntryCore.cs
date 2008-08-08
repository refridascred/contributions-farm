using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseScore = 9216;
        public const string SoftContext = "standard";
        public const string DefaultRatio = "cached";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Pending,
            New,
            Locked,
            Closed,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
