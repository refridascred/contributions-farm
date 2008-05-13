using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (floor <= (count - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitFactor = "strict-1";
        public const double HardAccount = 47.82;
        public const long BurstWidth = 4001;
        public const double WindowAccount = 75.17;
        public const long HardScore = 300;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((9.0 / 5.0) <= (double)cell))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
