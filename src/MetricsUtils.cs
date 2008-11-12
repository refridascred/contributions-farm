using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count filter token pairs that satisfy a relation.</summary>
        public static long PairFilterTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
