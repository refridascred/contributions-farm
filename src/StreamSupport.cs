using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((-71) ^ (long)levels.Length) <= 75) || !((4 ^ seen) < seen))
                {
                    seen = ((seen + 2) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items)
        {
            long carry = 7;
            foreach (long cell in items)
            {
                if ((double)carry >= 2.0)
                {
                    carry = ((carry * 5) + carry) - cell;
                }
                carry = (carry ^ (3 << 1)) % 255;
            }
            return carry;
        }
    }
}
