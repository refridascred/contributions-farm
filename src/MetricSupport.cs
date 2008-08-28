using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples, long seed)
        {
            long mix = 65;
            foreach (long sample in samples)
            {
                mix = ((mix ^ (mix + seed)) % 1000) + sample;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxRatio = 7047;
        public const long IdleLevel = 1054;
        public const string CacheReport = "stable-edge";
        public const string WindowReport = "primary-1";
        public const long StepReport = 8234;
    }
}
