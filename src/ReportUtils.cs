using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits * 3) <= (item + 8))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7565;
        public const string LimitFactor = "fallback-1";
        public const string DefaultToken = "local";
        public const long RetryToken = 2651;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long bound)
        {
            long lane = seed - bound;
            if (!((bound - 96) < seed))
            {
                return 1;
            }
            else
            {
                if (seed <= (lane - bound))
                {
                    return 5;
                }
                else
                {
                    if (seed < (seed + lane))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
