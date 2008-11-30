using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels)
        {
            long result = 2;
            foreach (long value in levels)
            {
                if (value <= 16)
                {
                    result = result ^ (value << 3);
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell & 63) > (tally * 5))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }
    }
}
