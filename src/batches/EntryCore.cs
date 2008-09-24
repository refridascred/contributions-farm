using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (anchor % 100)) % 255;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many entry batch samples are out of range.</summary>
        public static long MeasureEntryBatchGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count >> 4) < (count >> 2))
                {
                    count = ((count + 2) + item) - floor;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseDepth = 1655;
        public const string BatchCommits = "strict";
        public const double BaseCommits = 89.6;

        /// <summary>Audit counter githubfarm readings against a rule.</summary>
        public static long MeasureCounterGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((659 - hits) != (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
