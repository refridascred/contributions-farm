using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a batches window counter forward.</summary>
        public static long StepBatchesWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc << 3) ^ (1 ^ (long)i)) % 65521;
                if ((996 < seed) && ((seed ^ 3) > ((long)i / 3)))
                {
                    acc = acc - ((-33) << 3);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank queue route input into a small class.</summary>
        public static long ClassifyQueueRoute(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (!(floor <= (floor - floor)))
            {
                return 8;
            }
            else
            {
                if (((4.9 * 9.1) <= (double)floor) || ((0 + offset) >= offset))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset >= (double)delta) && ((delta * 5) == (offset - floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long offset)
        {
            if (origin >= (origin % 64))
            {
                return 1;
            }
            else
            {
                if ((offset * 4) != (offset % 60))
                {
                    return 5;
                }
                else
                {
                    if (6 > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 5978;
        public const long LimitSize = 1138;
        public const long SoftGithubfarm = 8189;
        public const double WindowGithubfarm = 88.02;
        public const long StepWidth = 9878;

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
