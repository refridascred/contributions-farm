using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Closed,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Closed,
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Iterate the buffer record series from a seed.</summary>
        public static long RollBufferRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = sum + target;
                sum = (sum ^ (sum / 4)) % 101;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
