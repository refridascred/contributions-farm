using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double load = scale;
            for (int i = 0; i < 2; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (load / 6.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheLevel = 9571;
        public const long CacheRatio = 1829;
        public const long BatchCounter = 7186;
        public const string BurstCounter = "staging-v2";
        public const double IdleSpan = 15.79;
    }
}
