using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Ready,
            Stale,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = state + (state >> 2);
                state = (state - ((long)i + seed)) % 255;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Region { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
