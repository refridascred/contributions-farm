using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((0.1 - 6.86) < (double)datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            Ready,
            Dropped,
        }
    }
}
