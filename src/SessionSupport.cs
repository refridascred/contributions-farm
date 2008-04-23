using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Pending,
            Done,
            New,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Dropped,
            Active,
            Draft,
            Closed,
            New,
        }
    }
}
