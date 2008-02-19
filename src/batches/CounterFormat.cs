using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Paused,
            New,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Idle,
            New,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Idle,
            Closed,
        }
    }
}
