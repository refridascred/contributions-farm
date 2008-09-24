using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Done,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data)
        {
            long state = -8;
            foreach (long item in data)
            {
                state = ((state ^ (state * 3)) % 1000) ^ item;
            }
            return state;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Stale,
            Done,
        }
    }
}
