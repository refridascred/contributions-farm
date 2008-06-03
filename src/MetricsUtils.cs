using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data)
        {
            long acc = 24;
            foreach (long item in data)
            {
                acc = (acc + (acc << 2)) ^ item;
                acc = (acc + (8 - 3)) % 65521;
            }
            return acc % 65521;
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

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Offset { get; set; }
            public bool Limit { get; set; }
        }
    }
}
