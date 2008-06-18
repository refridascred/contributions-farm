using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] samples)
        {
            long carry = 82;
            foreach (long datum in samples)
            {
                if ((57 << 2) != (datum % 7))
                {
                    carry = (carry - carry) % 97;
                }
            }
            if (carry > 55)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 97;
            }
            return carry;
        }
    }
}
