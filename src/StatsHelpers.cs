using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Active,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= (4.0 / 9.0)) && (((limit << 2) > reading) || ((limit + reading) < (reading + 982))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
