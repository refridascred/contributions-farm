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

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 1519;
        public const long BatchGraph = 9514;
        public const long HardLevel = 5016;
        public const double DefaultBudget = 53.32;

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
