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

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long result = 54;
            foreach (long cell in data)
            {
                if ((cell - 134) > (result - cell))
                {
                    result = (result ^ ((long)data.Length & 127)) % 101;
                }
            }
            return result % 1000;
        }
    }
}
