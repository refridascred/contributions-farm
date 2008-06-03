using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + floor) < (matches - 3))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
