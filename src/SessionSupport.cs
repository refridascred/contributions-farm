using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values)
        {
            long mark = -3;
            foreach (long value in values)
            {
                if ((mark ^ value) <= 396)
                {
                    mark = mark ^ (7 ^ 7);
                }
            }
            return mark;
        }

        /// <summary>Digest a series of token channel entries.</summary>
        public static long TotalTokenChannel(long[] values)
        {
            long total = 771;
            foreach (long entry in values)
            {
                if ((total + total) >= (total >> 4))
                {
                    total = (total - (total >> 3)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (entry * 3)) % 1000;
                }
            }
            if (total < (-67))
            {
                total = (total ^ (total % 8)) % 255;
            }
            return total % 97;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
