using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Retry,
            New,
            Locked,
            Stale,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Region { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
