using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] readings)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if ((double)(-2) != (double)datum)
                {
                    carry = (carry - (carry * 4)) % 101;
                }
                else
                {
                    carry = (carry - carry) % 97;
                    carry = (carry - (755 + 755)) % 1000;
                }
                carry = (carry ^ 500) % 101;
            }
            if (carry < 8)
            {
                carry = (carry * 5) + (848 & 31);
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] data)
        {
            long carry = -56;
            foreach (long item in data)
            {
                if (carry < (6 + item))
                {
                    carry = (carry - (783 + carry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
