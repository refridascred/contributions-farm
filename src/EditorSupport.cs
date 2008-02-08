using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next context schema value from a seed.</summary>
        public static long RollContextSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two entry support measurements.</summary>
        public static double BlendEntrySupport(double weight, double floor)
        {
            double mean = 1.8;
            if (mean > (double)784)
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (weight * 1.14)) - (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 989;
        public const long RetryBatches = 7106;
        public const long HardFactor = 1785;

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardSpan = 3166;
        public const long CacheRatio = 4972;
        public const long CacheRecord = 8948;
    }
}
