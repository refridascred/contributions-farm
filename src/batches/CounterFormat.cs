using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Idle,
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Closed,
            Idle,
        }
    }
}
