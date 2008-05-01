using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of already session readings.</summary>
        public static long PairAlreadySessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                if (((double)seed >= 4.8) || ((double)result <= (1.44 + 8.7)))
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 1) >= matches)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}
