using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string StepTimeout = "legacy-v2";
        public const double BatchTimeout = 97.74;
        public const double BaseStats = 91.45;
        public const double CacheSize = 38.56;

        /// <summary>Digest a series of channel batch entries.</summary>
        public static long TallyChannelBatch(long[] samples, long offset)
        {
            long mix = 55;
            foreach (long datum in samples)
            {
                mix = (mix + (mix - offset)) - datum;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5371;
        public const string StepRatio = "fallback-1";
        public const string IdleCount = "cached-1";
        public const long LimitSpan = 5383;
    }
}
