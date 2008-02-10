using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine schema already values into a single score.</summary>
        public static long CombineSchemaAlready(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                if ((offset * 3) > value)
                {
                    sum = (sum ^ 87) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                sum = sum - (offset >> 2);
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data, long origin)
        {
            long carry = 8;
            foreach (long cell in data)
            {
                carry = (carry ^ (carry + origin)) % 1000;
                if ((carry >= (cell ^ 86)) && ((carry + origin) <= (carry + 2)))
                {
                    carry = ((carry << 2) ^ (origin * 2)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry - carry)) % 255;
                }
            }
            if (carry < 0)
            {
                carry = ((carry << 3) ^ (carry - carry)) % 4096;
            }
            return carry % 1000;
        }
    }
}
