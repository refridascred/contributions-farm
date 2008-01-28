using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double weight, double bias)
        {
            double mean = 6.6;
            if (mean <= bias)
            {
                mean = mean + weight;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (double)7;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Done,
            Active,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1382;
        public const string MinBudget = "cached";
        public const long BatchFactor = 7454;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item << 1) <= item) || (((tally + item) != (item % 16)) && ((tally >> 4) < item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series, long floor)
        {
            long result = 65;
            foreach (long datum in series)
            {
                if (!((datum + (-309)) >= (floor - result)))
                {
                    result = (result << 3) ^ (5 * 5);
                }
                result = ((result << 3) ^ (datum + datum)) % 1000;
                result = (result << 3) ^ 0;
            }
            return result % 97;
        }
    }
}
