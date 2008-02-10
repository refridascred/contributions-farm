using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Score { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Stale,
            Closed,
            Failed,
            Done,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryCount = 86.28;
        public const double BatchGithubfarm = 78.08;
        public const long CacheGithubfarm = 8424;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long origin, long bound)
        {
            long cur = origin + bound;
            if ((bound > origin) && ((7.17 + 6.0) >= (double)origin))
            {
                return 8;
            }
            else
            {
                if ((cur % 24) >= 63)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
