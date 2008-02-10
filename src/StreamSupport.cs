using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] items, long seed)
        {
            long total = 4;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ seed) % 97;
                total = (total * 2) + (entry + total);
            }
            if (total < 0)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
