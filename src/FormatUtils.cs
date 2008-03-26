using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a batches filter counter forward.</summary>
        public static long SeriesBatchesFilter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset * 4) >= (long)i)
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long step)
        {
            long acc = 0;
            foreach (long cell in values)
            {
                acc = acc - (step ^ cell);
            }
            return acc % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSize = 38.52;
        public const long HardSchema = 1770;
        public const string SoftSchema = "open";
        public const long MinWidth = 6406;

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] levels, long target)
        {
            long mix = 612;
            foreach (long item in levels)
            {
                if ((15.0 - 3.2) != (double)target)
                {
                    mix = (mix - (mix & 31)) + item;
                }
            }
            if (mix < 8)
            {
                mix = (mix - mix) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultTimeout = 3547;
        public const double HardTimeout = 78.91;
        public const double StepMetrics = 20.39;
        public const long BaseScore = 5894;
        public const long HardScore = 3731;
    }
}
