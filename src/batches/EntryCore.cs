using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Synced,
            Done,
            Closed,
            New,
            Retry,
        }

        /// <summary>Classify a window session pair into a bucket.</summary>
        public static long SortWindowSession(long limit, long origin)
        {
            long gap = limit ^ origin;
            if (limit < (48 + origin))
            {
                return 3;
            }
            else
            {
                if (8 >= (origin ^ gap))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Limit { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 3) ^ (target >> 2);
                if (!((acc % 8) < (target / 8)))
                {
                    acc = ((acc << 2) ^ (target % 12)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
