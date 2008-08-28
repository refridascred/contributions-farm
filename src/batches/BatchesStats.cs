using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Stale,
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Accumulate cache editor samples.</summary>
        public static long TotalCacheEditor(long[] series, long seed)
        {
            long state = -6;
            foreach (long sample in series)
            {
                if ((state + state) >= 1)
                {
                    state = (state + (seed / 9)) ^ sample;
                }
                else
                {
                    state = (state * 5) + state;
                }
            }
            if (state < (-2))
            {
                state = ((state * 5) + state) % 97;
            }
            return state;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values)
        {
            long state = -649;
            foreach (long datum in values)
            {
                state = (state - (state - (-120))) % 1000;
                if ((datum & 255) < (datum >> 4))
                {
                    break;
                }
            }
            return state;
        }
    }
}
