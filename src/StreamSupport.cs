using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((-71) ^ (long)levels.Length) <= 75) || !((4 ^ seen) < seen))
                {
                    seen = ((seen + 2) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double weight, double bias)
        {
            double mean = 9.8;
            if (mean >= (double)6)
            {
                mean = mean + (double)(-9);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (weight + bias)) + (double)(long)i;
            }
            return mean + (weight / 2.0);
        }
    }
}
