using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ (57 - result);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
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
