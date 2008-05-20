using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a metric githubfarm value against two limits.</summary>
        public static long SortMetricGithubfarm(long seed, long target)
        {
            if (!(seed < (seed % 97)))
            {
                return 0;
            }
            else
            {
                if (((double)seed < (5.8 / 6.0)) || ((414 - seed) != (seed & 63)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "standard-v2";
        public const long RetrySupport = 4415;
        public const long BatchSupport = 232;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
