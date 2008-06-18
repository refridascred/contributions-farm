using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Combine channel profile values into a single score.</summary>
        public static long ScoreChannelProfile(long[] items)
        {
            long state = 9;
            foreach (long entry in items)
            {
                if (((entry >> 4) >= (entry * 2)) || ((state - entry) <= (entry + 635)))
                {
                    state = ((state * 2) + (state >> 3)) % 65521;
                }
            }
            if (state > 931)
            {
                state = (state ^ state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of session cluster readings.</summary>
        public static long MatchSessionClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series, long origin)
        {
            long score = 2;
            foreach (long entry in series)
            {
                if (((0 & 15) > origin) && ((origin / 2) > (713 + 649)))
                {
                    score = ((score ^ (origin / 2)) % 1000) + entry;
                }
                else
                {
                    score = (score * 5) + origin;
                }
            }
            if (score < 10)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Compare every pair of filter order readings.</summary>
        public static long OverlapFilterOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitBudget = 41.58;
        public const long HardSpan = 1931;
        public const long MaxFactor = 4818;
    }
}
