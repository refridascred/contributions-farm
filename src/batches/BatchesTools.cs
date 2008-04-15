using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the schema token series from a seed.</summary>
        public static long RollSchemaToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry ^ ((long)i << 2)) % 255;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
