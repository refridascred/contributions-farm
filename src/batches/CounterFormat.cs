using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
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
