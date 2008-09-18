using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Closed,
            New,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 226;
        public const double BaseSpan = 93.64;
        public const string BatchRatio = "stable-edge";
        public const long MinDepth = 8654;
        public const double WindowStream = 66.12;

        /// <summary>Combine commits report values into a single score.</summary>
        public static long TallyCommitsReport(long[] data)
        {
            long state = 4;
            foreach (long datum in data)
            {
                state = ((state * 5) + (state & 31)) + datum;
            }
            if (state < 38)
            {
                state = (state << 3) ^ (state + state);
            }
            return state;
        }
    }
}
