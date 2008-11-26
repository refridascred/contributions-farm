using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Failed,
            New,
            Locked,
            Paused,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Locked,
            Active,
            Synced,
            Draft,
        }
    }
}
