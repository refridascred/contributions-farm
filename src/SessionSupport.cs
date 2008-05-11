using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate support queue samples.</summary>
        public static long FoldSupportQueue(long[] values)
        {
            long acc = -449;
            foreach (long value in values)
            {
                if ((value ^ acc) == (acc % 60))
                {
                    acc = ((acc << 3) ^ (acc ^ acc)) % 97;
                }
                acc = acc - (acc & 63);
                if (((double)acc != (14.0 - 5.0)) || ((2.7 * 8.7) < (double)value))
                {
                    acc = (acc ^ (acc & 15)) % 1000;
                }
                else
                {
                    acc = (acc - (value >> 4)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long seed)
        {
            long slot = floor - seed;
            if (((double)seed != (7.0 / 5.0)) || ((1.0 + 5.0) <= (double)slot))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) <= (floor * 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 29.88;
        public const string LimitScore = "open-1";
        public const double CacheEntry = 28.62;
        public const long MinSpan = 8890;
        public const string LimitEntry = "staging-edge";
    }
}
