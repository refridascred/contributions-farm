using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Paused,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Locked,
            Ready,
        }
    }
}
