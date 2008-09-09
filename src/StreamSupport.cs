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

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double weight, double bias)
        {
            double gain = 2.51;
            if (gain < (gain / 5.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain - (7.38 / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (weight / 9.0)) + (double)(long)i;
            }
            return gain - (weight + gain);
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
