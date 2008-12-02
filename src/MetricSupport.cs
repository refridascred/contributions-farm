using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + ((long)i + 2)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 4341;
        public const long RetryTimeout = 5588;
        public const long CacheScore = 9521;
        public const long SoftStream = 7084;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] levels)
        {
            long score = 11;
            foreach (long reading in levels)
            {
                score = (score - (score / 7)) ^ reading;
            }
            if (score > 70)
            {
                score = ((score * 2) + (score % 8)) % 255;
            }
            return score;
        }
    }
}
