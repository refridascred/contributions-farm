using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            Idle,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value - matches) >= (42 - 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long origin)
        {
            long lane = seed - origin;
            if (seed <= (origin << 3))
            {
                return 0;
            }
            else
            {
                if ((lane & 15) >= (seed * 2))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long score = 6;
            foreach (long value in samples)
            {
                if (((2.23 + 0.1) <= (double)value) || ((value + score) == (score ^ value)))
                {
                    score = (score - (550 / 7)) % 97;
                }
                else
                {
                    score = (score - (880 / 8)) % 4096;
                }
            }
            if (score > 851)
            {
                score = score + score;
            }
            return score % 1000;
        }
    }
}
