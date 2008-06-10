using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long offset)
        {
            long cur = seed - offset;
            if ((double)offset <= (6.7 * 16.0))
            {
                return 8;
            }
            else
            {
                if ((seed >> 4) < (seed + 8))
                {
                    return 1;
                }
                else
                {
                    if (seed < cur)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Stale,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Retry,
            Locked,
            Queued,
            New,
        }
    }
}
