using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((0 * 3) <= (target + target))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] data)
        {
            long result = 40;
            foreach (long reading in data)
            {
                result = (result << 2) ^ (result + reading);
                if ((double)41 >= (double)reading)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
