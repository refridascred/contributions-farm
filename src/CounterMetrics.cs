using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long TallyMetricsGraphGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((10.0 - 8.84) <= (double)matches)
                {
                    matches = ((matches + 1) ^ datum) - seed;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many commits batches samples are out of range.</summary>
        public static long TallyCommitsBatchesMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + entry) < (seen - seen))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
