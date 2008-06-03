using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + offset) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 9359;
        public const long BaseOrder = 17;
        public const string DefaultWidth = "primary-edge";
        public const long SoftDepth = 6188;
    }
}
