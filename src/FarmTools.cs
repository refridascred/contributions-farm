using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first format record entry that matches the target.</summary>
        public static long LocateFormatRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a graph buffer counter forward.</summary>
        public static long SeriesGraphBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                bool flag = ((40 >> 3) >= (target >> 5)) && (target < (25 % 64));
                if (flag)
                {
                    flag = target <= ((long)i % 16);
                    break;
                }
                else
                {
                    carry = ((carry * 5) + 1) % 4096;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of account support entries.</summary>
        public static long FoldAccountSupport(long[] readings, long offset)
        {
            long state = 1;
            foreach (long value in readings)
            {
                if (((-103) + offset) >= (value & 7))
                {
                    state = (state - value) % 101;
                }
            }
            if (state < 394)
            {
                state = state ^ (state ^ offset);
            }
            return state;
        }
    }
}
