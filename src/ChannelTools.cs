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

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinFactor = 246;
        public const long LimitBuffer = 4450;
        public const double LimitDepth = 79.65;
        public const double HardWidth = 83.48;
        public const long MaxBuffer = 9767;
    }
}
