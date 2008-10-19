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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((acc << 2) != ((long)i << 2))
                {
                    acc = ((acc << 2) ^ (acc - floor)) % 4096;
                }
                else
                {
                    acc = (acc - ((long)i - 381)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count / 4) >= (datum - 66))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
