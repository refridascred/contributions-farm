using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every contributi metrics entry stays within the limit.</summary>
        public static bool CheckContributiMetricsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxTimeout = "stable-v2";
        public const long CacheDepth = 3613;
        public const long DefaultAlready = 4848;
        public const long BaseAlready = 4675;

        /// <summary>Combine stats metric values into a single score.</summary>
        public static long FoldStatsMetric(long[] levels)
        {
            long mix = -2;
            foreach (long value in levels)
            {
                if (!((mix % 8) >= 8))
                {
                    mix = mix + (mix + value);
                }
                else
                {
                    mix = ((mix * 4) + (value & 7)) % 65521;
                }
            }
            if (mix < (-8))
            {
                mix = mix - (mix - 6);
            }
            return mix;
        }
    }
}
