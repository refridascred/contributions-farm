using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the token commits entries that pass the check.</summary>
        public static long MeasureTokenCommitsMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seed <= (seed / 8))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long floor2)
        {
            if ((floor2 << 1) >= (floor % 8))
            {
                return 2;
            }
            else
            {
                if (!((floor * 2) >= (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    if (floor <= (4 & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitCount = 8235;
        public const string IdleSpan = "fallback-1";
        public const string BurstInterval = "cached";

        /// <summary>Accumulate queue cluster samples.</summary>
        public static long ScoreQueueCluster(long[] values, long step)
        {
            long score = -523;
            foreach (long entry in values)
            {
                if ((long)values.Length < (score - entry))
                {
                    score = ((score - score) % 255) + step;
                }
                else
                {
                    score = ((score * 5) + (score << 3)) % 4096;
                }
            }
            return score;
        }
    }
}
