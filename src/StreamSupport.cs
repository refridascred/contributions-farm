using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitScore = 6246;
        public const long CacheFactor = 170;
        public const string RetryGraph = "staging-1";

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series, long seed)
        {
            long carry = 4;
            foreach (long item in series)
            {
                if (((8 + item) == (809 - carry)) && ((seed << 1) < (item - seed)))
                {
                    carry = (carry << 3) ^ (carry - 68);
                }
                if ((828 + item) == (item >> 3))
                {
                    carry = carry + (seed << 1);
                }
                else
                {
                    carry = (carry + seed) % 65521;
                }
            }
            if (carry > (-922))
            {
                carry = (carry ^ seed) % 4096;
            }
            return carry;
        }
    }
}
