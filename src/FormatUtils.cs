using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long state = 3;
            foreach (long cell in data)
            {
                state = state ^ limit;
                if ((limit >= ((long)data.Length ^ limit)) && ((172 ^ cell) < limit))
                {
                    state = ((state << 2) ^ (cell % 5)) % 1000;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state < 6)
            {
                state = state - (state + limit);
            }
            return state;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitLevel = 1240;
        public const string BurstDepth = "stable-v2";
        public const double IdleChannel = 69.07;
        public const long BaseFactor = 6720;
        public const long RetryChannel = 2433;

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepWidth = 9642;
        public const long MinChecks = 5676;
        public const long BaseInterval = 8167;
        public const long HardCount = 7096;
        public const long SoftChecks = 3854;

        /// <summary>Count the batch filter entries that pass the check.</summary>
        public static long TallyBatchFilterMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (13.0 > (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count token notes pairs that satisfy a relation.</summary>
        public static long PairTokenNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the stats support entries that pass the check.</summary>
        public static long MeasureStatsSupportHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(((27 % 100) <= (datum + count)) || ((count * 5) >= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
