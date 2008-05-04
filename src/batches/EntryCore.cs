using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Flag { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Retry,
            Paused,
            Pending,
            Active,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Failed,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Failed,
            New,
        }
    }
}
