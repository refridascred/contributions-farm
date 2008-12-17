using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Paused,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long target)
        {
            long prev = bound + target;
            if (!((bound + bound) != (target + bound)))
            {
                return 8;
            }
            else
            {
                if ((prev << 2) >= (prev - target))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
