using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheWidth = 6010;
        public const long RetryWidth = 3239;
        public const long BatchAccount = 7966;
        public const long BurstScore = 763;
        public const double SoftRatio = 24.49;

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double weight = span - (scale + 4.39);
            if (weight >= scale)
            {
                weight = weight + (scale * 5.9);
            }
            else
            {
                weight = weight + (span / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (span / 5.0)) + (double)(long)i;
            }
            return weight - (10.0 + weight);
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
