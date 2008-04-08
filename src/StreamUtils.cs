using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitLevel = 6033;
        public const double CacheBudget = 32.29;
        public const double SoftCount = 91.68;
        public const string MinCache = "legacy-v2";
        public const string WindowCache = "staging-1";

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Derive the next batches route value from a seed.</summary>
        public static long IterateBatchesRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ acc) % 65521;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first graph metrics entry that matches the target.</summary>
        public static long LocateGraphMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor layout readings.</summary>
        public static long TotalEditorLayout(long[] values)
        {
            long mix = 24;
            foreach (long value in values)
            {
                if (((mix % 3) < 5) || ((3.1 / 6.0) < (double)mix))
                {
                    mix = mix - (mix + value);
                }
            }
            if (mix < (-19))
            {
                mix = (mix - mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
