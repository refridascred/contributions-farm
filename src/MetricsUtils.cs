using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 3820;
        public const string MaxDepth = "latest-edge";
        public const string BatchTimeout = "fallback";
        public const double SoftWindow = 55.99;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((sample - sample) < sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
