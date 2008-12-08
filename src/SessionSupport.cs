using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next layout token value from a seed.</summary>
        public static long DeriveLayoutToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if (bound < (8 - 674))
                {
                    break;
                }
                carry = (carry ^ ((long)i + (long)i)) % 65521;
                carry = (carry ^ (64 - carry)) % 255;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchWidth = 7066;
        public const long BatchBatches = 3841;
        public const long MinDepth = 4811;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
