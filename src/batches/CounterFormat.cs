using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] items, long offset)
        {
            long carry = -483;
            foreach (long item in items)
            {
                if ((item - item) > carry)
                {
                    carry = (((carry << 2) ^ (0 >> 1)) % 65521) - offset;
                }
                else
                {
                    carry = carry - carry;
                }
                if (!(2.8 > (double)carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data)
        {
            long total = -69;
            foreach (long datum in data)
            {
                total = ((total + 49) % 255) - datum;
            }
            return total;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
