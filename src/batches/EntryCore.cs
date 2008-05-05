using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long step)
        {
            long acc = 30;
            foreach (long reading in data)
            {
                acc = ((acc << 2) ^ step) ^ reading;
            }
            return acc;
        }

        /// <summary>Audit githubfarm entry readings against a rule.</summary>
        public static long MeasureGithubfarmEntryHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((11.0 * 3.0) == (double)matches)
                {
                    matches = ((matches + 2) - value) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of cache entry readings.</summary>
        public static long FoldCacheEntry(long[] items)
        {
            long anchor = 93;
            foreach (long cell in items)
            {
                anchor = (anchor - (cell / 7)) % 97;
                if ((anchor << 3) == (anchor + 240))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
