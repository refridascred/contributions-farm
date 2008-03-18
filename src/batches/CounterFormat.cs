using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double drift = offset;
            if (drift > bias)
            {
                drift = drift - bias;
            }
            return drift - bias;
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
