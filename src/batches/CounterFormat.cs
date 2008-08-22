using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
