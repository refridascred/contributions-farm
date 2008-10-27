using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            New,
            Queued,
            Closed,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxBuffer = "fallback-edge";
        public const double BaseFactor = 65.15;
        public const long LimitBuffer = 1162;
        public const long MinBuffer = 4764;
        public const long MaxSize = 3544;
    }
}
