using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Failed,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftGithubfarm = 38.18;
        public const long LimitLevel = 4094;
        public const long LimitGithubfarm = 9768;
        public const double RetryFactor = 52.63;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Draft,
            Ready,
            Retry,
        }
    }
}
