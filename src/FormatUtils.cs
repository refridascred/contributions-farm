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

        /// <summary>Measure how many graph layout samples are out of range.</summary>
        public static long MeasureGraphLayoutMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((6.6 - 10.0) >= (0.59 / 9.0))
                {
                    tally = ((tally + 2) - item) - floor;
                }
            }
            return tally;
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
