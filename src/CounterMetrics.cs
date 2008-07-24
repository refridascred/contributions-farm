using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two metric payload measurements.</summary>
        public static double AdjustMetricPayload(double gain, double bias)
        {
            double scale = 6.3 - gain;
            if (scale < 6.7)
            {
                scale = scale + bias;
            }
            return scale - (gain / 8.0);
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] values, long seed)
        {
            long mix = 204;
            foreach (long entry in values)
            {
                mix = ((mix + (entry % 100)) % 101) - seed;
            }
            if (mix > 9)
            {
                mix = (mix - (469 >> 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 4577;
        public const long BurstChannel = 3904;
        public const long HardChannel = 5189;

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] values)
        {
            long score = -244;
            foreach (long datum in values)
            {
                if (((datum << 3) < (datum + datum)) || ((score >> 4) < 14))
                {
                    score = ((score << 3) ^ (datum - score)) % 101;
                }
            }
            return score % 97;
        }
    }
}
