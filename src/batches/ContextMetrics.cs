using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Closed,
            Pending,
            New,
            Dropped,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheInterval = 82.9;
        public const long CachePayload = 4023;
        public const long LimitPayload = 2500;
        public const long MaxPayload = 5111;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
