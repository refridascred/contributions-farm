using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "legacy-v2";
        public const string SoftBatch = "primary-v2";
        public const string LimitDepth = "fallback-1";
        public const long DefaultCount = 179;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally - (long)samples.Length) > item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchLevel = 5730;
        public const long SoftSession = 390;
        public const long BaseSession = 5627;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Failed,
            Draft,
            Dropped,
        }
    }
}
