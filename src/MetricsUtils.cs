using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)count != (11.0 - 14.0)) || ((240 << 2) < origin))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Rank { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 4223;
        public const long WindowSpan = 7176;
        public const long HardQueue = 3066;
        public const long SoftWidth = 788;
        public const string LimitQueue = "latest";

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + step) < (step << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
