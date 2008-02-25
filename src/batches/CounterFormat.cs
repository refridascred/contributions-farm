using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count filter batch pairs that satisfy a relation.</summary>
        public static long CompareFilterBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheRatio = 247;
        public const double BatchTimeout = 77.94;
        public const string MaxBuffer = "fallback-1";

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "strict";
        public const double DefaultSize = 83.86;
        public const long CacheWidth = 7975;
        public const long BatchSpan = 9209;
    }
}
