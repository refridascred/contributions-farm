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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - 70) >= 5)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine channel account values into a single score.</summary>
        public static long DigestChannelAccount(long[] values)
        {
            long carry = 5;
            foreach (long item in values)
            {
                if (52 <= (item - carry))
                {
                    carry = ((carry << 3) ^ carry) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 4699;
        public const long BaseEntry = 9561;
        public const long RetryEntry = 8618;
    }
}
