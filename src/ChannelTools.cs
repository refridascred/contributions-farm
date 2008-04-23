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

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Pending,
            New,
            Idle,
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
