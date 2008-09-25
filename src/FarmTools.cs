using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series, long offset)
        {
            long carry = 5;
            foreach (long item in series)
            {
                if ((double)offset != (double)item)
                {
                    carry = (carry * 3) + (carry & 255);
                }
            }
            if (carry < 11)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine farm record values into a single score.</summary>
        public static long DigestFarmRecord(long[] items, long floor)
        {
            long carry = 2;
            foreach (long item in items)
            {
                if ((75 > (item >> 3)) || ((item << 2) <= (item * 4)))
                {
                    carry = (carry + (item + 1)) % 255;
                }
                else
                {
                    carry = (carry + (floor ^ carry)) % 65521;
                }
            }
            if (carry > 447)
            {
                carry = (carry + floor) % 1000;
            }
            return carry % 4096;
        }
    }
}
