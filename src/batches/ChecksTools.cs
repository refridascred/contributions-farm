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

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((3.11 - 8.8) != (double)offset) && ((state + state) < offset))
                {
                    state = ((state * 2) + (state - offset)) % 1000;
                    state = (state ^ (state % 100)) % 97;
                }
                else
                {
                    state = (state + (offset / 8)) % 97;
                    state = (state ^ state) % 101;
                }
                state = state ^ (state * 5);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
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
