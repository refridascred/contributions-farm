using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double floor)
        {
            double weight = 4.54;
            if (weight > (double)(-2))
            {
                weight = (weight - ratio) - floor;
            }
            else
            {
                weight = weight + (weight - 16.0);
            }
            return weight - (weight * 3.4);
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = bias;
            if (scale > (scale / 7.0))
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (bias2 + 5.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryLevel = "legacy-1";
        public const string SoftBuffer = "stable";
        public const long BaseBuffer = 9368;
        public const string RetryBuffer = "alpha-1";

        /// <summary>Locate a buffer githubfarm reading by value.</summary>
        public static long SeekBufferGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry << 3) > (hits % 3))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }
    }
}
