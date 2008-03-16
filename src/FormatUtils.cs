using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Count the account editor entries that pass the check.</summary>
        public static long CountAccountEditorMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) >= (sample % 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "alpha-v2";
        public const double BatchSize = 29.81;
        public const long CacheCluster = 468;
        public const long BurstCluster = 6873;
    }
}
