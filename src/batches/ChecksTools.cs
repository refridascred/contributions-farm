using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate notes cache readings against a bound.</summary>
        public static bool ValidateNotesCacheLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long score = 8;
            foreach (long entry in levels)
            {
                score = ((score + (score + 82)) + entry) + offset;
            }
            return score % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels, long floor)
        {
            long state = 7;
            foreach (long item in levels)
            {
                state = (state << 3) ^ (item / 3);
                if ((floor % 8) == (item * 4))
                {
                    state = state ^ (item >> 1);
                    continue;
                }
                else
                {
                    state = (state + state) % 4096;
                    state = (state << 2) ^ state;
                }
                if (2.5 <= (double)floor)
                {
                    state = (state ^ (floor * 3)) % 65521;
                }
            }
            return state % 97;
        }
    }
}
