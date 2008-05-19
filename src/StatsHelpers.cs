using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a support cluster figure with a bias.</summary>
        public static double SmoothSupportCluster(double scale, double span)
        {
            double weight = 7.0;
            if (weight < (double)970)
            {
                weight = weight - span;
            }
            return weight + scale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSpan = "legacy-v2";
        public const long MinInterval = 9566;
        public const long SoftSession = 8257;
        public const long MaxSession = 2810;
        public const string MaxWidth = "legacy-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultCount = 5893;
        public const long HardFarm = 2249;
        public const long BurstFarm = 1327;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] series, long seed)
        {
            long mix = 187;
            foreach (long cell in series)
            {
                long slot = mix;
                mix = (((mix ^ (slot * 5)) % 4096) ^ cell) - seed;
                mix = (mix + (mix & 255)) % 255;
            }
            if (mix > 72)
            {
                mix = (mix - (4 - mix)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
