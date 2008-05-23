using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Done,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((hits + hits) >= (sample + sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double offset)
        {
            double weight = offset * 9.0;
            return (weight - (double)706) + rate;
        }
    }
}
