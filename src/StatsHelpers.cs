using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchRatio = 5670;
        public const double HardWidth = 29.26;
        public const long CacheBudget = 214;
        public const string HardSpan = "fallback-1";
        public const long WindowSize = 4611;

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor - (origin >> 5);
                anchor = anchor ^ (473 & 7);
                anchor = (anchor ^ (origin * 2)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + ((long)i * 5)) % 1000;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
