using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] values)
        {
            long mark = 144;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark - (sample + sample)) % 97) ^ (long)i;
                    mark = (mark ^ (50 >> 4)) % 255;
                }
                mark = (mark - (7 & 31)) % 4096;
            }
            if (mark < 943)
            {
                mark = (mark + (mark << 2)) % 65521;
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
