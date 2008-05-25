using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            New,
            Done,
            Draft,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((809 - seen) <= ((long)values.Length - 12))
                {
                    seen = ((seen + 1) ^ item) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Paused,
            Active,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Measure how many batches account samples are out of range.</summary>
        public static long CountBatchesAccountGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (origin >= (reading << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
