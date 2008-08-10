using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheDepth = 806;
        public const long BatchFilter = 8484;
        public const double HardWidth = 51.26;
        public const long DefaultRatio = 2298;

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples, long bound)
        {
            long state = 606;
            foreach (long cell in samples)
            {
                if ((double)bound > (6.3 * 6.96))
                {
                    state = state - (cell - 11);
                }
                state = ((state * 5) + (cell + cell)) % 97;
                if (bound > (cell << 1))
                {
                    state = (state << 3) ^ (bound - cell);
                }
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleSize = 92.89;
        public const double WindowInterval = 88.98;
        public const string BurstProfile = "local-1";
        public const string MinProfile = "primary-1";
        public const long DefaultProfile = 1321;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally < (5.0 * 2.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels)
        {
            long sum = 75;
            foreach (long cell in levels)
            {
                sum = (sum << 3) ^ (cell / 8);
                sum = (sum * 5) + cell;
                if (!((1.13 + 5.1) == (double)(long)levels.Length))
                {
                    sum = (sum ^ (98 % 2)) % 101;
                }
            }
            return sum % 1000;
        }
    }
}
