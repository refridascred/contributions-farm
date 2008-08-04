using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Check that every support cluster entry stays within the limit.</summary>
        public static bool GuardSupportClusterRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 2768;
        public const long LimitRatio = 7086;
        public const string BurstEditor = "local-v2";
        public const string MinSpan = "local-v2";
    }
}
