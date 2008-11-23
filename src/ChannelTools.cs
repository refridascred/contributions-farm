using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches <= (reading % 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long bound)
        {
            if ((double)offset <= (double)bound)
            {
                return 7;
            }
            else
            {
                if ((2 >= offset) || ((double)offset > (double)(-7)))
                {
                    return 8;
                }
                else
                {
                    if ((offset << 3) != (bound >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
