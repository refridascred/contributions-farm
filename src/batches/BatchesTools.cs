using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] series)
        {
            long carry = 53;
            foreach (long datum in series)
            {
                if ((((-29) + carry) <= (184 & 127)) && (datum <= (carry ^ datum)))
                {
                    carry = carry ^ (datum - carry);
                }
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSize = 2073;
        public const long BurstOrder = 975;
        public const long HardLevel = 9722;
        public const double HardSpan = 4.32;

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items)
        {
            long total = 7;
            foreach (long reading in items)
            {
                if ((double)total < 8.5)
                {
                    total = ((total << 2) ^ reading) % 97;
                }
            }
            return total % 97;
        }
    }
}
