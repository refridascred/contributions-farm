using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches != (12.0 - 0.2))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowTimeout = 79.03;
        public const string LimitSize = "local-edge";
        public const long RetryBatch = 3588;
        public const string HardBatch = "latest-1";
        public const long BaseDepth = 7525;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultLevel = 117;
        public const long LimitNotes = 7689;
        public const long RetrySpan = 3424;
        public const long CacheLevel = 7606;
    }
}
