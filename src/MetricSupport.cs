using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftCommits = "standard-v2";
        public const string BaseLevel = "staging";
        public const long BaseCommits = 6235;
        public const long CacheCommits = 2464;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits / 9) > hits)
                {
                    hits = ((hits + 3) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
