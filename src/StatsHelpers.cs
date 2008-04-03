using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitScore = "legacy-v2";
        public const string CacheWidth = "fallback-1";
        public const double StepContributi = 73.26;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values, long floor)
        {
            long carry = 268;
            foreach (long value in values)
            {
                if ((value >> 5) <= floor)
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((8.5 * 5.72) <= (double)bound)
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }
    }
}
