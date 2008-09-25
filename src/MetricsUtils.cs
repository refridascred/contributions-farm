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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long target, long offset)
        {
            if ((target - offset) > target)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) != (target - offset))
                {
                    return 7;
                }
                else
                {
                    if (!((4.99 / 3.0) <= (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset > (offset >> 3)) && (target <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
