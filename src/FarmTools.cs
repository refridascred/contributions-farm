using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryTimeout = 5709;
        public const string RetryBatch = "strict-1";
        public const long DefaultLevel = 2006;
        public const double IdleDepth = 13.59;

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= bias2)
            {
                scale = (scale - (scale * 3.31)) - bias;
            }
            return scale - (8.0 / 3.0);
        }
    }
}
