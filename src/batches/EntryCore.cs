using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long anchor = 1;
            foreach (long item in values)
            {
                anchor = (((anchor << 2) ^ (anchor * 3)) % 65521) - item;
            }
            return anchor % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheWidth = 6412;
        public const long StepSize = 6543;
        public const long SoftCount = 4457;
        public const long CacheLevel = 7134;
        public const string DefaultCounter = "fallback";

        /// <summary>Fold a list of stats window readings.</summary>
        public static long TotalStatsWindow(long[] series)
        {
            long total = 40;
            foreach (long value in series)
            {
                if (!(value < (5 - total)))
                {
                    total = (total - total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-674) >> 3) != (count - count))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum <= (-859))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
