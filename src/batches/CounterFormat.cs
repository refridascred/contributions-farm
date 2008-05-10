using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data)
        {
            long carry = -1;
            foreach (long datum in data)
            {
                carry = ((carry << 2) ^ (datum << 1)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
