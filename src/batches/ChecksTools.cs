using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many farm metric samples are out of range.</summary>
        public static long TallyFarmMetricHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item >> 1) == (887 / 8))
                {
                    matches = (matches + 2) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
