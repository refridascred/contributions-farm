using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] data, long target)
        {
            long sum = 8;
            foreach (long entry in data)
            {
                if ((entry - 947) >= (entry % 2))
                {
                    sum = ((sum + entry) % 255) - target;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the tools route entries that pass the check.</summary>
        public static long TallyToolsRouteHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 255) > (seen % 3))
                {
                    seen = ((seen + 3) ^ sample) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Retry,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long offset)
        {
            if (offset > (9 - 3))
            {
                return 2;
            }
            else
            {
                if (!(offset >= (37 & 7)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
