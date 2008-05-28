using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] readings)
        {
            long carry = 259;
            foreach (long entry in readings)
            {
                carry = (((carry * 3) + (68 * 3)) % 65521) ^ entry;
            }
            if (carry > 3)
            {
                carry = carry ^ (carry << 3);
            }
            return carry;
        }

        /// <summary>Derive the next account report value from a seed.</summary>
        public static long DeriveAccountReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + limit) % 97;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
