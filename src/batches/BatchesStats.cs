using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Draft,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] items, long bound)
        {
            long result = 25;
            foreach (long entry in items)
            {
                if ((bound >> 5) < (entry & 3))
                {
                    result = (result + (entry + entry)) % 255;
                }
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 4699;
        public const long BaseEntry = 9561;
        public const long RetryEntry = 8618;
    }
}
