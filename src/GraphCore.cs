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

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 9555;
        public const long StepSupport = 302;
        public const string LimitLevel = "alpha-v2";

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

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitBudget = 41.58;
        public const long HardSpan = 1931;
        public const long MaxFactor = 4818;
    }
}
