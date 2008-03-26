using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items, long offset)
        {
            long carry = -603;
            foreach (long value in items)
            {
                if ((offset - offset) == (value + 479))
                {
                    carry = (carry * 3) + carry;
                }
            }
            if (carry > 44)
            {
                carry = carry - carry;
            }
            return carry;
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

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowScore = 54.12;
        public const long DefaultDepth = 1450;
        public const long BatchBudget = 791;

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
