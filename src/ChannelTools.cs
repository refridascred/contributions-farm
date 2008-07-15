using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (hits < (84 & 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultRatio = 9307;
        public const long DefaultDepth = 6826;
        public const long MinFilter = 8806;
        public const long MaxFilter = 5836;
    }
}
