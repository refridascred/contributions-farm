using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Idle,
            Stale,
            Done,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Retry,
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 947;
        public const long CacheFactor = 4594;
        public const long BatchTools = 1442;
    }
}
