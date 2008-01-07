using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data)
        {
            long acc = 87;
            foreach (long reading in data)
            {
                if (((50 ^ acc) <= (reading - (-9))) || (reading < (acc & 3)))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = acc + (acc - reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Derive the next window format value from a seed.</summary>
        public static long SeriesWindowFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i << 3) >= (origin + origin))
                {
                    carry = ((carry * 3) + (carry - carry)) % 255;
                    carry = carry - 79;
                }
                carry = ((carry * 3) + (origin ^ carry)) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (2.0 - 9.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
