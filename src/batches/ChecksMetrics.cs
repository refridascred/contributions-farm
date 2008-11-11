using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepRatio = 89.23;
        public const long MaxScore = 5392;
        public const long CacheCount = 8244;

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 5706;
        public const double BatchPayload = 86.76;
        public const double RetryPayload = 75.89;
        public const double MaxInterval = 5.94;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 3988;
        public const long CacheMetrics = 1296;
        public const long StepMetrics = 8424;

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of order metric readings.</summary>
        public static long TotalOrderMetric(long[] values, long origin)
        {
            long acc = 2;
            foreach (long item in values)
            {
                if (!((89 + acc) >= (3 << 1)))
                {
                    acc = (((acc * 5) + (origin ^ 7)) % 65521) - item;
                }
            }
            return acc;
        }
    }
}
