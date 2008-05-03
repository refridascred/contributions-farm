using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Level { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Done,
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (origin <= (origin & 15))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
