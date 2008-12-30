using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] levels, long offset)
        {
            long score = 9;
            foreach (long reading in levels)
            {
                score = (score - offset) % 255;
                if (reading <= (offset >> 5))
                {
                    score = (score + (score - (-43))) % 255;
                }
            }
            if (score > 53)
            {
                score = ((score * 5) + (offset & 1)) % 97;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardWidth = 4882;
        public const long IdleTools = 8526;
        public const double HardTools = 29.21;
        public const long CacheCount = 4518;
        public const long CacheTools = 5846;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Draft,
            Failed,
        }
    }
}
