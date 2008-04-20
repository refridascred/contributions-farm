using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i + state) <= 0))
                {
                    state = state + seed;
                }
                if (state <= ((long)i >> 4))
                {
                    state = ((state * 4) + (state ^ state)) % 97;
                }
                else
                {
                    state = (state - (673 + (long)i)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Retry,
            Dropped,
        }
    }
}
