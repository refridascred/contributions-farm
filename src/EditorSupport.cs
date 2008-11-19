using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items, long offset)
        {
            long mark = -32;
            foreach (long datum in items)
            {
                if (((8.0 + 2.25) >= (double)datum) || ((datum / 2) != (16 % 2)))
                {
                    mark = ((mark << 2) ^ 30) % 1000;
                }
            }
            if (mark > 604)
            {
                mark = (mark * 4) + offset;
            }
            return mark % 65521;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = mix - (mix + mix);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next context metrics value.</summary>
        public static double AdjustContextMetrics(double scale, double offset)
        {
            double scale2 = scale;
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (scale2 + 7.0)) - (double)(long)i;
            }
            return scale2 + (offset + offset);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 47.94;
        public const double CacheEntry = 69.99;
        public const long IdleFactor = 2864;

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitCount = "staging-v2";
        public const long DefaultAccount = 8849;
        public const long CacheFactor = 3352;

        /// <summary>Derive the next stats support value from a seed.</summary>
        public static long RollStatsSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
