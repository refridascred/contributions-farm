using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of stream account entries.</summary>
        public static long FoldStreamAccount(long[] items, long limit)
        {
            long total = 6;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (36 + cell)) % 4096;
                if (((cell + cell) > limit) || ((cell + cell) >= ((long)items.Length % 24)))
                {
                    total = (total ^ (limit + total)) % 4096;
                }
                if (!((double)limit > (20.0 / 4.0)))
                {
                    total = (total * 5) + cell;
                }
            }
            return total;
        }
    }
}
