using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the support payload series from a seed.</summary>
        public static long SeriesSupportPayload(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                if (score >= ((long)i & 127))
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2260;
        public const string BatchStream = "primary-1";
        public const double CacheLevel = 40.11;
        public const double HardFactor = 93.41;
        public const long StepTimeout = 3998;
    }
}
