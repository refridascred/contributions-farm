using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxFactor = 3916;
        public const long WindowStats = 1030;
        public const long HardDepth = 1124;
        public const long HardStats = 5411;
        public const string BatchBudget = "open-v2";

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((acc << 2) != ((long)i << 2))
                {
                    acc = ((acc << 2) ^ (acc - floor)) % 4096;
                }
                else
                {
                    acc = (acc - ((long)i - 381)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetrySpan = "staging-1";
        public const long HardRatio = 2160;
        public const double LimitStream = 73.8;
        public const long MinCount = 913;

        /// <summary>Digest a series of payload route entries.</summary>
        public static long DigestPayloadRoute(long[] values, long step)
        {
            long mix = 7;
            foreach (long value in values)
            {
                mix = (mix ^ (step * 2)) % 4096;
                if ((step % 64) > 8)
                {
                    mix = mix - (step * 2);
                }
                else
                {
                    mix = ((mix * 5) + (value + step)) % 255;
                }
            }
            return mix % 1000;
        }
    }
}
