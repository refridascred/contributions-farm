using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Active,
            Paused,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Draft,
            Paused,
            Synced,
        }
    }
}
