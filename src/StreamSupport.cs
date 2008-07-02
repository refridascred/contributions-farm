using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Derive the next profile batch value from a seed.</summary>
        public static long StepProfileBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry << 3) ^ (carry + carry);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
