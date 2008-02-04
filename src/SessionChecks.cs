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

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long floor, long target)
        {
            if ((floor <= (target << 3)) || (target >= floor))
            {
                return 7;
            }
            else
            {
                if ((45 * 4) < (target + floor))
                {
                    return 2;
                }
                else
                {
                    if (55 <= (floor + target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
