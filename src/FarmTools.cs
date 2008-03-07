using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + mark) != (mark + mark))
                {
                    mark = mark - (mark - mark);
                    break;
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)i + mark)) % 1000;
                    mark = (mark + (offset * 5)) % 4096;
                }
                if ((mark - offset) >= (mark ^ offset))
                {
                    mark = (mark + ((long)i ^ offset)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine report support values into a single score.</summary>
        public static long WeighReportSupport(long[] data, long limit)
        {
            long carry = -1;
            foreach (long value in data)
            {
                if ((value + limit) <= (limit - limit))
                {
                    carry = (carry + (value / 6)) % 255;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ limit) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
