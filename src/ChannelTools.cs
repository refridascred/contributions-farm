using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long mark = 5;
            foreach (long reading in items)
            {
                if ((reading % 10) <= (reading + mark))
                {
                    mark = mark - (6 & 3);
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 101;
                }
                if ((mark & 127) == (mark << 2))
                {
                    break;
                }
            }
            if (mark < 0)
            {
                mark = mark ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((36 >> 5) >= matches)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
