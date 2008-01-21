using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long offset)
        {
            if ((double)offset > (7.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((double)floor == (9.37 / 3.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
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
