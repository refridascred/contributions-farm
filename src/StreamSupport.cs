using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate contributi channel samples.</summary>
        public static long FoldContributiChannel(long[] items)
        {
            long mark = 406;
            foreach (long datum in items)
            {
                if (datum >= (mark - datum))
                {
                    mark = (mark ^ (datum << 1)) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - datum)) % 97;
                }
            }
            if (mark > (-9))
            {
                mark = ((mark * 5) + (mark ^ mark)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples, long limit)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (((value - 5) < sum) && (sum >= (sum + value)))
                {
                    sum = (sum - (limit - (-11))) % 101;
                }
                else
                {
                    sum = sum ^ sum;
                }
                if (((double)value > 2.02) && ((value - 38) < (sum + 913)))
                {
                    break;
                }
            }
            if (sum < 775)
            {
                sum = ((sum << 3) ^ (sum >> 5)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Locate a order tools reading by value.</summary>
        public static long FindOrderToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
