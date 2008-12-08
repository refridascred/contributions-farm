using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long target, long limit)
        {
            if (target < limit)
            {
                return 1;
            }
            else
            {
                if ((limit & 7) != (target >> 4))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Paused,
            Queued,
            Synced,
            Stale,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long floor)
        {
            long step = bound + floor;
            if ((floor / 7) != (floor & 1))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) < bound)
                {
                    return 7;
                }
                else
                {
                    if ((step - step) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.59 / 2.0) == (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
