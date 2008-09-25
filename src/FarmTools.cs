using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits stream samples.</summary>
        public static long WeighCommitsStream(long[] values)
        {
            long result = 991;
            foreach (long datum in values)
            {
                if (result >= (datum - datum))
                {
                    result = (result << 2) ^ (36 + datum);
                }
            }
            return result % 4096;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
