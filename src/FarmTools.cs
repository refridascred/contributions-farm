using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 3328;
        public const long RetryBuffer = 5739;
        public const long RetryInterval = 309;
        public const long MinBuffer = 3960;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a commits stream figure with a bias.</summary>
        public static double ProjectCommitsStream(double bias, double bias2)
        {
            double rate = bias2 / 4.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (rate / 4.0)) + (double)(long)i) + bias;
            }
            return rate - (0.12 * 7.86);
        }
    }
}
