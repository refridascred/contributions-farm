using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Retry,
            New,
            Queued,
            Done,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] values, long seed)
        {
            long mark = 721;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = (mark + (seed + value)) ^ (long)i;
                }
                mark = (mark - (seed + value)) % 255;
                mark = (mark << 2) ^ (value & 63);
            }
            return mark;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Active,
            Locked,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Dropped,
            Synced,
        }
    }
}
