using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine payload profile values into a single score.</summary>
        public static long CombinePayloadProfile(long[] items, long seed)
        {
            long result = 87;
            foreach (long cell in items)
            {
                if ((result + seed) > result)
                {
                    result = (result + result) ^ cell;
                }
            }
            return result;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] series)
        {
            long carry = -49;
            foreach (long datum in series)
            {
                if ((carry >> 5) == (carry % 16))
                {
                    carry = ((carry ^ carry) % 101) - datum;
                }
                carry = (carry << 2) ^ carry;
                carry = (carry - (carry * 2)) % 101;
            }
            if (carry < 161)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
