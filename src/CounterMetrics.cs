using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Audit cache metrics readings against a rule.</summary>
        public static long MeasureCacheMetricsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample / 2) <= (4 - 91))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count != (9.82 * 15.0))
                {
                    count = ((count + 3) ^ value) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
