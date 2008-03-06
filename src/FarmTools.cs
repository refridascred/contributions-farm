using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine support channel values into a single score.</summary>
        public static long FoldSupportChannel(long[] levels)
        {
            long mark = 190;
            foreach (long datum in levels)
            {
                mark = ((mark - mark) % 101) ^ datum;
                mark = mark ^ mark;
            }
            if (mark > 53)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if (!((9 & 255) < (entry - (-95))))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 55)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Ready,
        }
    }
}
