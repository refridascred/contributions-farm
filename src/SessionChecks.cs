using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the buffer farm series from a seed.</summary>
        public static long SeriesBufferFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = sum - 32;
                if (!((long)i >= sum))
                {
                    sum = (sum << 2) ^ (bound - (long)i);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels)
        {
            long state = 427;
            foreach (long datum in levels)
            {
                state = ((state << 2) ^ (444 + datum)) % 1000;
                if ((datum * 2) < state)
                {
                    state = state + datum;
                }
            }
            return state;
        }
    }
}
