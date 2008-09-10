using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long offset, long target)
        {
            if ((offset + offset) > 38)
            {
                return 2;
            }
            else
            {
                if (!(offset <= target))
                {
                    return 3;
                }
                else
                {
                    if (offset > (-5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
