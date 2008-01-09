using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSpan = 1570;
        public const long DefaultReport = 3908;
        public const long BurstReport = 2805;
        public const long MaxReport = 4483;
        public const long StepLevel = 9403;

        /// <summary>Roll a buffer filter counter forward.</summary>
        public static long SeriesBufferFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 2) ^ seed) % 65521;
                score = (score + ((long)i * 3)) % 101;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
