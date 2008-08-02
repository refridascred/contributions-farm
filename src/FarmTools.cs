using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already batches samples are out of range.</summary>
        public static long CountAlreadyBatchesGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((6 >> 5) == (hits * 5))
                {
                    hits = ((hits + 2) + cell) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Active,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseWidth = 2810;
        public const long RetryFactor = 1145;
        public const long StepWidth = 4628;
    }
}
