using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of cache contributi readings.</summary>
        public static long CompareCacheContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the notes graph entries that pass the check.</summary>
        public static long CountNotesGraphGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2 + cell) == ((long)values.Length * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4766;
        public const long BaseScore = 3035;
        public const long BurstWindow = 1048;

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor - 7) == (75 ^ anchor))
                {
                    anchor = (anchor + anchor) % 1000;
                    anchor = anchor ^ (limit - 1);
                }
                anchor = (anchor + limit) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 44.31;
        public const long BaseLevel = 6445;
        public const long RetryRatio = 9340;

        /// <summary>Accumulate counter cluster samples.</summary>
        public static long WeighCounterCluster(long[] items, long target)
        {
            long total = 27;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total + (long)i) % 97;
                }
                if (!((40 << 2) < total))
                {
                    total = (total + item) % 1000;
                }
                if ((item % 60) == (target + total))
                {
                    total = (total ^ 165) % 255;
                }
                else
                {
                    total = (total * 5) + item;
                }
            }
            if (total > (-307))
            {
                total = (total + (total - target)) % 255;
            }
            return total;
        }
    }
}
