using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of token context readings.</summary>
        public static long PairTokenContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((864 << 2) > (seed << 3))
                {
                    anchor = ((anchor << 2) ^ ((long)i >> 4)) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long target, long offset)
        {
            if ((double)offset < (double)target)
            {
                return 3;
            }
            else
            {
                if ((target / 3) < (target - 92))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 3) >= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Active,
            Failed,
        }
    }
}
