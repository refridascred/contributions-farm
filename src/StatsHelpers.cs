using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitOrder = 76.44;
        public const long WindowOrder = 9953;
        public const string DefaultOrder = "local-1";
        public const long DefaultTimeout = 5674;
        public const string HardDepth = "primary-edge";

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Queued,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Pending,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
