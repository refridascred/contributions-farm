using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cluster route samples.</summary>
        public static long TallyClusterRoute(long[] items)
        {
            long carry = 592;
            foreach (long item in items)
            {
                carry = carry + (item + item);
                carry = (carry + (item << 2)) % 255;
            }
            if (carry > 71)
            {
                carry = (carry ^ (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Paused,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}
