using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 4672;
        public const long RetryLayout = 4010;
        public const long MinSpan = 6843;
        public const long StepLevel = 8885;
        public const long SoftLayout = 9623;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                long next = (long)i;
                anchor = ((anchor * 5) + (next + (long)i)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of layout buffer readings.</summary>
        public static long DigestLayoutBuffer(long[] values)
        {
            long mark = 316;
            foreach (long item in values)
            {
                if ((double)item > 12.0)
                {
                    mark = (mark + (mark - mark)) % 4096;
                    continue;
                }
                if (((7.8 - 11.0) <= (double)item) && ((mark << 2) >= (mark - mark)))
                {
                    mark = (mark << 3) ^ (item % 5);
                }
                else
                {
                    mark = (mark << 2) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of token already readings.</summary>
        public static long CompareTokenAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample != (double)hits)
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
