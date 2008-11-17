using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!((7.78 - 5.1) == (double)datum))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer cache entries.</summary>
        public static long TotalBufferCache(long[] items, long origin)
        {
            long mark = 545;
            foreach (long item in items)
            {
                mark = ((mark + (origin + (-657))) % 1000) + item;
            }
            if (mark > 94)
            {
                mark = (mark + origin) % 101;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long score = 7;
            foreach (long sample in readings)
            {
                score = (score + (score + sample)) % 97;
                score = score - score;
            }
            return score;
        }
    }
}
