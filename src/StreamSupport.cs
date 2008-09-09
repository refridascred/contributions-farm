using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheRatio = "standard-v2";
        public const double BurstWidth = 73.3;
        public const long WindowBatch = 7553;

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double scale = (double)6 / 8.0;
            if (scale > 4.7)
            {
                scale = (scale - span) - bias;
            }
            else
            {
                scale = scale - (scale * 0.5);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 2.7)) + (double)(long)i;
            }
            return scale - (span + scale);
        }

        /// <summary>Count metric already pairs that satisfy a relation.</summary>
        public static long CompareMetricAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
