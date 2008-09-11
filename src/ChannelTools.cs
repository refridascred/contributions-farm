using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] series)
        {
            long state = 340;
            foreach (long cell in series)
            {
                state = state + (cell >> 1);
                state = (state - (29 >> 5)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-86) < (cell + cell)) || (((1.16 - 11.0) < 20.0) && ((double)cell <= (19.0 * 15.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
