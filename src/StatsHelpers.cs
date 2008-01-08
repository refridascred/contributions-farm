using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Paused,
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Find the first session support entry that matches the target.</summary>
        public static long SeekSessionSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Dropped,
            Stale,
            Draft,
            Ready,
        }
    }
}
