using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxLevel = 0.89;
        public const long BurstBatches = 6464;
        public const double IdleBatches = 82.07;
        public const long StepRatio = 9630;
        public const long BaseSpan = 8324;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate queue format readings against a bound.</summary>
        public static bool GuardQueueFormatBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
