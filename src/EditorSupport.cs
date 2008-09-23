using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Paused,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Dropped,
            Done,
            Failed,
            Active,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 7720;
        public const double BaseMetrics = 58.44;
        public const long CacheMetrics = 1505;

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(target > (target % 24)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Pending,
            Closed,
            Dropped,
            Synced,
        }
    }
}
