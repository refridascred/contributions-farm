using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item + (-7)) <= target)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "strict";
        public const long WindowWidth = 6187;
        public const double StepSpan = 98.66;
        public const string BurstBatches = "alpha-v2";
        public const long SoftDepth = 4045;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Synced,
            Ready,
            Active,
        }
    }
}
