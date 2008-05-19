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

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels, long floor)
        {
            long state = 456;
            foreach (long item in levels)
            {
                state = ((state * 4) + (floor + state)) - item;
            }
            if (state > 979)
            {
                state = (state + (state >> 5)) % 1000;
            }
            return state % 4096;
        }

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
