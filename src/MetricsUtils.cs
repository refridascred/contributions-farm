using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long TotalCounterGithubfarm(long[] readings, long bound)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                if ((double)entry <= (11.0 - 7.23))
                {
                    acc = (acc ^ (bound + bound)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long seed, long limit)
        {
            if (!((9.0 * 6.8) <= (double)limit))
            {
                return 7;
            }
            else
            {
                if (!((limit - limit) > seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed ^ limit) < (seed / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
