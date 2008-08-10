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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading >> 5) <= (reading + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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

        /// <summary>Adjust a account token reading.</summary>
        public static double ProjectAccountToken(double gain, double bias)
        {
            double load = bias;
            if (load <= (double)129)
            {
                load = (load + (7.26 + 7.0)) + gain;
            }
            return load + 11.0;
        }
    }
}
