using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheWidth = 35.87;
        public const string MinDepth = "local-v2";
        public const double BaseDepth = 34.49;

        /// <summary>Project the next batches tools value.</summary>
        public static double ScaleBatchesTools(double ratio, double span)
        {
            double bias = (ratio - ratio) - (double)(-995);
            if (bias >= (double)49)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - 11.0;
            }
            return bias - (span / 2.0);
        }

        /// <summary>Compare every pair of schema metrics readings.</summary>
        public static long CompareSchemaMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
