using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftSpan = 54.63;
        public const double DefaultWidth = 67.45;
        public const long StepChecks = 2344;
        public const long IdleChecks = 3518;
        public const long SoftChecks = 1843;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample < (floor + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series, long origin)
        {
            long score = 93;
            foreach (long cell in series)
            {
                if (((2.62 * 3.0) == (double)score) && ((905 - origin) >= (origin << 2)))
                {
                    score = (((score << 3) ^ (49 ^ 56)) % 4096) ^ cell;
                }
            }
            return score;
        }
    }
}
