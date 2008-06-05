using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinLevel = 8226;
        public const long BatchSpan = 4151;
        public const double BatchSchema = 83.26;
        public const long HardScore = 5258;

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = (result + ((long)i - result)) % 65521;
                result = (result ^ (bound + (long)i)) % 1000;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + (mix + bound)) % 97;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix * 2) + bound) % 255) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 191;
        public const string BurstProfile = "strict";
        public const double BurstScore = 19.78;
        public const long MinFactor = 3996;

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double ratio, double offset)
        {
            double bias = 1.2;
            if (bias > bias)
            {
                bias = (bias - (double)642) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - ratio;
        }
    }
}
