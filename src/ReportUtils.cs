using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum < (long)values.Length)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Check that every channel window entry stays within the limit.</summary>
        public static bool VerifyChannelWindowBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowBudget = 422;
        public const double SoftContributi = 15.29;
        public const long RetryContributi = 1792;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4790;
        public const long MaxSchema = 2350;
        public const double IdleSchema = 20.37;
        public const long HardSchema = 7445;
        public const double HardSize = 91.03;
    }
}
