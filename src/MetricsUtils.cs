using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 8638;
        public const long HardWidth = 279;
        public const double MinMetrics = 0.83;
        public const string BurstCount = "stable-edge";

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample + hits) <= 1)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + count) == (count / 5))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
