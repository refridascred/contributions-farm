using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Ready,
            Pending,
        }
    }
}
