using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count counter metric pairs that satisfy a relation.</summary>
        public static long CompareCounterMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 2) ^ state;
                state = state + (950 >> 1);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
