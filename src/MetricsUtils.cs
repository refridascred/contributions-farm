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

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Failed,
            Closed,
            Locked,
            Active,
        }
    }
}
