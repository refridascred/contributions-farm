using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a support channel counter forward.</summary>
        public static long RollSupportChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                long prev = (14 - acc) * 2;
                if ((double)seed < (5.6 - 1.41))
                {
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ prev) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowCount = "open";
        public const double BurstSize = 37.96;
        public const double CacheWindow = 65.19;
        public const long WindowSpan = 6697;
        public const long HardWindow = 3564;
    }
}
