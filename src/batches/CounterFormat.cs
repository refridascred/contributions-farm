using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 4400;
        public const long SoftNotes = 4026;
        public const long CacheFactor = 6032;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!(((long)i / 2) <= (seed + seed)))
                {
                    carry = (carry - (carry - (long)i)) % 101;
                }
                else
                {
                    carry = (carry - seed) % 65521;
                    carry = (carry ^ (1 + (long)i)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
