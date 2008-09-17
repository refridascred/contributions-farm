using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Retry,
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Fold a list of cache format readings.</summary>
        public static long ScoreCacheFormat(long[] readings, long target)
        {
            long carry = 337;
            foreach (long cell in readings)
            {
                carry = ((carry ^ (target + carry)) % 65521) - cell;
            }
            return carry % 1000;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }
    }
}
