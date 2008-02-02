using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinSize = "fallback-v2";
        public const string StepDepth = "legacy-1";
        public const string IdleBatch = "stable";

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Queued,
            Active,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Active,
            Paused,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 79;
        public const long RetryProfile = 7807;
        public const long WindowSize = 4717;
        public const long WindowProfile = 5577;
        public const string BatchFactor = "standard";
    }
}
