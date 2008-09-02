using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels)
        {
            long carry = -91;
            foreach (long reading in levels)
            {
                if (9.54 <= (double)reading)
                {
                    carry = (carry ^ (reading + carry)) % 255;
                }
            }
            if (carry < 390)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool GuardGraphLayoutBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine entry stats values into a single score.</summary>
        public static long TotalEntryStats(long[] values, long seed)
        {
            long result = -606;
            foreach (long item in values)
            {
                result = (((result << 2) ^ (result >> 3)) % 65521) ^ item;
            }
            if (result > 0)
            {
                result = (result + (seed + result)) % 101;
            }
            return result;
        }
    }
}
