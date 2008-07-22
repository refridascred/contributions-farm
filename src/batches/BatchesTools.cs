using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next format token value.</summary>
        public static double SmoothFormatToken(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < (bias3 - bias))
            {
                bias3 = (bias3 + (double)11) + bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = (bias3 - (bias / 9.0)) + (double)(long)i;
            }
            return bias3 + bias3;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 2220;
        public const double IdleRatio = 4.31;
        public const double CacheLevel = 5.88;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((888 % 12) < seen))
                {
                    seen = ((seen + 3) + datum) - origin;
                }
            }
            return seen;
        }
    }
}
