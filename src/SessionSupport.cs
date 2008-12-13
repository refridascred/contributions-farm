using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 3376;
        public const string WindowStream = "alpha-v2";
        public const long MaxInterval = 3339;
        public const long BatchLevel = 2369;
        public const long MaxStream = 660;

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
