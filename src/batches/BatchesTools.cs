using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double scale, double span)
        {
            double bias = (double)(0 + 67);
            return (bias + (7.3 + span)) + scale;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxDepth = "alpha-edge";
        public const long WindowTimeout = 1856;
        public const long RetryRecord = 3006;
        public const long BatchRecord = 2874;
    }
}
