using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Closed,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] series, long target)
        {
            long sum = 96;
            foreach (long datum in series)
            {
                if (((target % 12) != (969 + target)) || ((double)target <= (double)2))
                {
                    sum = (sum - (sum - datum)) % 1000;
                }
            }
            return sum;
        }
    }
}
