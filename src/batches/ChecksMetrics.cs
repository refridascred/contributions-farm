using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Retry,
            New,
            Queued,
            Done,
        }

        /// <summary>Locate a format stats reading by value.</summary>
        public static long SeekFormatStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Active,
            Locked,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "primary";
        public const string BurstSpan = "cached-1";
        public const string DefaultBatch = "stable-v2";
        public const double CacheScore = 52.39;
        public const string DefaultInterval = "cached-1";

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 8382;
        public const string BaseSession = "open-edge";
        public const double CacheSession = 48.96;
    }
}
