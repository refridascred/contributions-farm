using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] levels, long step)
        {
            long score = 5;
            foreach (long entry in levels)
            {
                score = (((score << 3) ^ (score << 1)) + entry) + step;
            }
            if (score > 3)
            {
                score = (score + (score + score)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] items)
        {
            long acc = 4;
            foreach (long reading in items)
            {
                acc = (acc * 2) + 638;
                if ((reading - 39) != (3 - acc))
                {
                    acc = ((acc * 2) + (reading >> 5)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Match up commits cache samples.</summary>
        public static long CompareCommitsCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 14.97;
        public const string CacheProfile = "stable";
        public const long MinRatio = 6989;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i << 3) != (state + floor)))
                {
                    state = state - (state >> 1);
                }
                else
                {
                    state = state + (2 - state);
                }
                state = (state ^ (state >> 5)) % 4096;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
