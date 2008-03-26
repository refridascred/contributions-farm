using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
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

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double rate, double span)
        {
            double ratio = rate + (double)33;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (rate + ratio)) + (double)(long)i) + span;
            }
            return ratio - (rate - ratio);
        }
    }
}
