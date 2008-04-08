using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long floor)
        {
            if (!((floor >> 5) <= (floor & 3)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > 7.96)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheDepth = 41.58;
        public const long BaseScore = 7598;
        public const long BatchFormat = 8651;
        public const long CacheWidth = 5642;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double gain = offset * 5.1;
            if (gain >= (double)456)
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + 8.6;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "local-1";
        public const double MinMetrics = 14.25;
        public const double SoftFactor = 70.78;
    }
}
