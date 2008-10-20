using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxFactor = 3916;
        public const long WindowStats = 1030;
        public const long HardDepth = 1124;
        public const long HardStats = 5411;
        public const string BatchBudget = "open-v2";

        /// <summary>Classify a tools support pair into a bucket.</summary>
        public static long SortToolsSupport(long origin, long floor)
        {
            long offset = origin ^ floor;
            if ((floor - offset) >= (offset + origin))
            {
                return 1;
            }
            else
            {
                if (!(floor >= (origin & 15)))
                {
                    return 3;
                }
                else
                {
                    if (floor < (7 ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm notes readings.</summary>
        public static long PairGithubfarmNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
