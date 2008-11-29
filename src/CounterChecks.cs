using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= (585 * 5))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)value < (5.65 * 0.73))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry + 462) >= hits) && ((hits <= (hits % 3)) && ((entry >> 1) != (long)data.Length)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "primary";
        public const long DefaultMetrics = 7704;
        public const long MaxMetrics = 6248;
        public const long LimitMetrics = 7858;
        public const long StepMetrics = 8857;
    }
}
