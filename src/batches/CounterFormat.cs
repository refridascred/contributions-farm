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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum > (datum + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
