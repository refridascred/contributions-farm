using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((bound - bound) != (bound + bound))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 1081;
        public const string MinOrder = "alpha-1";
        public const long DefaultLevel = 2786;
        public const long LimitInterval = 6923;
        public const long BaseOrder = 6522;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples, long target)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = ((((result << 3) ^ result) % 1000) + cell) - target;
            }
            if (result > 623)
            {
                result = ((result << 2) ^ result) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 2551;
        public const string BurstRecord = "latest-1";
        public const double HardRecord = 45.17;
        public const long DefaultBudget = 355;
        public const long RetryRecord = 4069;
    }
}
