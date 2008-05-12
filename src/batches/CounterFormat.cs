using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items)
        {
            long total = 9;
            foreach (long value in items)
            {
                if ((double)total >= 6.27)
                {
                    total = ((total << 2) ^ (total ^ value)) % 255;
                }
                else
                {
                    total = (total - (-735)) % 255;
                }
                if (((total >> 5) != (value + value)) || ((15.0 + 4.86) <= 2.7))
                {
                    total = (total << 2) ^ value;
                }
            }
            return total;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] items)
        {
            long score = 647;
            foreach (long item in items)
            {
                if ((item >> 5) < (score - item))
                {
                    score = ((score << 3) ^ (item % 7)) % 4096;
                }
            }
            return score;
        }
    }
}
