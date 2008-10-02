using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftCommand = 18.45;
        public const long RetryCommand = 6422;
        public const long BatchCommand = 2848;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + (long)i) <= (71 << 1))
                {
                    state = ((state * 2) + state) % 101;
                }
                else
                {
                    state = (state * 2) + ((long)i % 8);
                }
                if (!(((double)origin > 6.31) || ((state - state) > state)))
                {
                    state = ((state << 2) ^ origin) % 255;
                }
                state = (state + state) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "open-v2";
        public const double BatchCache = 41.54;
        public const long BatchDepth = 286;
        public const double MinBudget = 2.83;
        public const long LimitCache = 6790;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseScore = 912;
        public const string BatchBatches = "fallback";
        public const long BurstWidth = 2789;
        public const long DefaultScore = 4746;
        public const long CacheBatches = 5111;
    }
}
