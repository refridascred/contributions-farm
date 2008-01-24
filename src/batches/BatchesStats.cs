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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public long Flag { get; set; }
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
