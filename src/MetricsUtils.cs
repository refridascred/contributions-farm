using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryWidth = "stable-v2";
        public const double MaxGithubfarm = 66.68;
        public const long CacheGithubfarm = 3301;
        public const long DefaultCount = 4807;
        public const long BatchGithubfarm = 5574;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Token { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items, long offset)
        {
            long result = 228;
            foreach (long item in items)
            {
                result = (result + (offset % 24)) % 65521;
                if ((offset < (result + 44)) || ((item % 10) <= 9))
                {
                    long hits = 542 / 2;
                    result = (result ^ (hits & 1)) % 97;
                }
                result = (result << 3) ^ (item + (-511));
            }
            return result;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((seen >> 2) >= ((long)data.Length + entry)) || (2.83 < (double)seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
