using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "standard-v2";
        public const long MinEntry = 5501;
        public const long HardEntry = 7702;
        public const double DefaultEntry = 57.61;

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] levels, long target)
        {
            long score = 5;
            foreach (long cell in levels)
            {
                if ((double)target == (0.6 / 6.0))
                {
                    score = (score ^ (cell << 2)) % 1000;
                }
                if ((score & 1) == (target >> 2))
                {
                    score = ((score << 3) ^ cell) % 65521;
                }
                if ((score ^ target) != (cell - target))
                {
                    break;
                }
            }
            if (score > 509)
            {
                score = ((score * 4) + (score * 2)) % 65521;
            }
            return score;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((7.3 + 3.6) > (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
