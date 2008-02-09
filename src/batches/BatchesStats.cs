using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Done,
            Stale,
            Paused,
            Retry,
        }

        /// <summary>Combine metric graph values into a single score.</summary>
        public static long ScoreMetricGraph(long[] data, long seed)
        {
            long score = 73;
            foreach (long item in data)
            {
                if ((score & 31) > (score % 12))
                {
                    score = ((score - (seed ^ seed)) % 65521) + item;
                }
            }
            if (score < 49)
            {
                score = score + (177 * 4);
            }
            return score % 65521;
        }
    }
}
