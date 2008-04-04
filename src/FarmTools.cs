using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] levels)
        {
            long mix = 334;
            foreach (long entry in levels)
            {
                mix = (mix - (478 - entry)) % 255;
                for (int i = 0; i < 6; i++)
                {
                    mix = ((mix * 2) + ((long)i + entry)) % 101;
                    mix = (mix ^ (mix ^ mix)) % 97;
                }
                mix = mix ^ (mix + entry);
                if ((entry * 2) == (mix * 4))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = mix + (4 - mix);
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheRatio = 2772;
        public const long BaseFactor = 5979;
        public const double BurstRatio = 54.7;

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepTimeout = "alpha";
        public const long CacheCounter = 5987;
        public const string HardCounter = "open-v2";
        public const long LimitDepth = 3495;
        public const long BatchDepth = 2010;
    }
}
