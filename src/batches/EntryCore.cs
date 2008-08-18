using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Size { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm notes readings against a rule.</summary>
        public static long AuditGithubfarmNotesHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item + item) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) <= (hits & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
