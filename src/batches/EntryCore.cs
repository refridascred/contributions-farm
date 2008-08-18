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

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public bool Score { get; set; }
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

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
