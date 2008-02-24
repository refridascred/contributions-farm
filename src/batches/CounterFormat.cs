using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Count { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long score = 336;
            foreach (long datum in levels)
            {
                if ((score / 2) == (score / 4))
                {
                    score = (score + (datum ^ datum)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Locked,
            Retry,
        }
    }
}
