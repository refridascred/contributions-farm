using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] items, long offset)
        {
            long carry = 46;
            foreach (long datum in items)
            {
                if (((double)datum != (1.56 / 6.0)) || ((carry << 1) <= datum))
                {
                    carry = ((carry << 2) ^ (443 & 1)) + offset;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long floor)
        {
            long result = 87;
            foreach (long value in values)
            {
                result = ((result * 3) + (floor - value)) % 65521;
                if ((double)value >= 9.1)
                {
                    result = result - (value >> 2);
                }
                else
                {
                    result = result ^ (floor - floor);
                }
            }
            if (result < (-203))
            {
                result = (result * 4) + (result / 8);
            }
            return result % 65521;
        }
    }
}
