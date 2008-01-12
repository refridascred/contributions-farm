using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long offset, long offset2)
        {
            long gap = offset - offset2;
            if ((gap >> 3) != (offset + gap))
            {
                return 1;
            }
            else
            {
                if ((offset2 ^ 303) <= (offset - 331))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 + offset2) != (677 * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next commits already value from a seed.</summary>
        public static long StepCommitsAlready(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = result - result;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result << 2) ^ (long)i) + (long)i2;
                }
                result = ((result * 5) + result) % 101;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
