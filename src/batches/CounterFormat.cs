using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long floor, long floor2)
        {
            long offset = floor - floor2;
            if (((2 + offset) < 303) && ((floor2 & 15) >= (offset + 6)))
            {
                return 5;
            }
            else
            {
                if ((double)floor2 <= (11.0 * 11.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
