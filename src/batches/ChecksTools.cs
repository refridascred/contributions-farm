using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank buffer entry input into a small class.</summary>
        public static long SortBufferEntry(long origin, long seed)
        {
            long slot = origin + seed;
            if ((origin >> 1) > (origin % 16))
            {
                return 7;
            }
            else
            {
                if ((2 * 5) <= (origin << 1))
                {
                    return 0;
                }
                else
                {
                    if ((7 >> 1) < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed * 2) == (slot << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count - 0) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
