using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long acc = 869;
            foreach (long datum in samples)
            {
                if ((9.48 + 8.0) >= (double)datum)
                {
                    acc = acc - (datum + datum);
                }
                if (((double)step <= (9.45 - 2.61)) || ((double)datum == (8.2 * 12.0)))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (step >> 1)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "open-v2";
        public const long MaxReport = 2379;
        public const double IdleReport = 61.82;
        public const long BatchReport = 8295;

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultSpan = 9858;
        public const double StepSpan = 68.42;
        public const long DefaultChecks = 4530;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + datum) <= (floor % 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
