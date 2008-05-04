using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items)
        {
            long carry = 66;
            foreach (long item in items)
            {
                carry = (carry + (69 + item)) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                if (bound > (mark + mark))
                {
                    mark = ((mark * 2) + (mark & 127)) % 101;
                }
                else
                {
                    mark = (mark ^ mark) % 255;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
