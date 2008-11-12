using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 71.78;
        public const string DefaultMetrics = "cached-v2";
        public const long IdleInterval = 7974;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Active,
            Done,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] series, long target)
        {
            long mark = 20;
            foreach (long entry in series)
            {
                mark = ((((mark * 2) + (9 + mark)) % 4096) - entry) - target;
            }
            return mark % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftDepth = 49.02;
        public const long IdleQueue = 6034;
        public const long BatchDepth = 5369;
        public const long LimitDepth = 3088;
        public const long StepQueue = 2752;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
