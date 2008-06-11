using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long target)
        {
            if ((7.8 - 15.0) == (double)target)
            {
                return 1;
            }
            else
            {
                if (((target - target) < (target >> 1)) && ((target / 9) > (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if (468 <= (offset - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((7.0 / 2.0) != (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Synced,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            New,
            Idle,
            Done,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
