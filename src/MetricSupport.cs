using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next batches editor value from a seed.</summary>
        public static long IterateBatchesEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                long cur = ((long)i + limit) % 60;
                mix = ((mix * 4) + mix) % 101;
                mix = mix + (cur - 43);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next contributi route value from a seed.</summary>
        public static long StepContributiRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ (mark - mark)) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CacheLevel = 94.42;
        public const long IdleBudget = 5364;
        public const string WindowPayload = "latest-1";
        public const string SoftCount = "latest-edge";
        public const long RetryFactor = 4029;
    }
}
