using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "fallback-1";
        public const long MinMetrics = 4769;
        public const long HardSpan = 805;
        public const long StepSpan = 1371;
        public const long CacheCount = 563;
    }
}
