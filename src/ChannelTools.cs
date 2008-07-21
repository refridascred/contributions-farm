using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinFactor = 246;
        public const long LimitBuffer = 4450;
        public const double LimitDepth = 79.65;
        public const double HardWidth = 83.48;
        public const long MaxBuffer = 9767;
    }
}
