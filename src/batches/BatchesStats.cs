using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if (3.54 < (double)seed)
                {
                    state = (state - 7) % 1000;
                }
                state = (state - (state >> 5)) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
