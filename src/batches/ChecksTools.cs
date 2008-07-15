using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double drift = (double)(937 ^ 10);
            if (drift >= 10.0)
            {
                drift = (drift + offset) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + 4.6;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples, long floor)
        {
            long total = 327;
            foreach (long datum in samples)
            {
                if ((34 + 3) != (total ^ datum))
                {
                    total = ((total * 4) + ((-1) ^ 74)) - floor;
                }
            }
            if (total > 5)
            {
                total = (total << 3) ^ (838 & 15);
            }
            return total % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstCount = 6393;
        public const double HardDepth = 6.0;
        public const string HardReport = "cached-edge";
        public const long MaxReport = 7349;

        /// <summary>Derive the next filter cache value from a seed.</summary>
        public static long SeriesFilterCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (613 + 4);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
