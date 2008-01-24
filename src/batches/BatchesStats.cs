using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Queued,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long mark = 864;
            foreach (long entry in data)
            {
                if (((entry << 2) == (37 % 24)) || ((entry + mark) < (mark << 3)))
                {
                    mark = ((mark * 3) + (42 + mark)) % 97;
                }
                else
                {
                    mark = ((mark << 2) ^ 850) % 255;
                }
                if ((entry % 24) <= (1 << 1))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = ((mark * 5) + mark) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long seed, long floor)
        {
            if ((9.3 / 7.0) == (double)floor)
            {
                return 5;
            }
            else
            {
                if ((83 & 63) > (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
