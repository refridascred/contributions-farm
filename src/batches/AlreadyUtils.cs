using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
