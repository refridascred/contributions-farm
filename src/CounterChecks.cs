using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Closed,
            Retry,
            Dropped,
            Synced,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstCache = "strict-v2";
        public const long MaxScore = 885;
        public const long HardRatio = 994;
        public const long LimitCache = 4591;
        public const string DefaultWidth = "stable-1";

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items, long offset)
        {
            long score = 68;
            foreach (long item in items)
            {
                score = (score - (item + item)) - offset;
                score = (score - (4 * 2)) % 255;
            }
            return score;
        }
    }
}
