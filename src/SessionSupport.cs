using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheTimeout = 48.94;
        public const double BaseWidth = 66.21;
        public const double DefaultSupport = 75.32;
        public const long HardLevel = 7518;

        /// <summary>Measure how many schema already samples are out of range.</summary>
        public static long MeasureSchemaAlreadyGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((8 + seen) < (origin << 1)))
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
