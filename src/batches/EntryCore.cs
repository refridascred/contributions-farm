using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Queued,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Closed,
            Idle,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4494;
        public const long WindowCache = 6383;
        public const long IdleCache = 8863;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Stale,
            Queued,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheRatio = 2034;
        public const long WindowChannel = 577;
        public const long SoftCount = 6544;
    }
}
