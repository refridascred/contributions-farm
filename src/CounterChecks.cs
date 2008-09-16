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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell >= (cell >> 1)) && (cell >= (cell + 0)))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
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
