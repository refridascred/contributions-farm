using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Ready,
            Dropped,
            Retry,
            Locked,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Dropped,
            Draft,
            Closed,
            Idle,
        }
    }
}
