using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine batches already values into a single score.</summary>
        public static long TotalBatchesAlready(long[] samples, long offset)
        {
            long sum = 6;
            foreach (long item in samples)
            {
                sum = (sum - (23 - item)) - offset;
            }
            return sum % 1000;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit record editor readings against a rule.</summary>
        public static long CountRecordEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (0.8 + 8.55))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
