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

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardDepth = 4888;
        public const long LimitFilter = 5709;
        public const double MinFilter = 55.93;

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
