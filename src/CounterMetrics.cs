using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long limit)
        {
            long sum = 976;
            foreach (long cell in readings)
            {
                if (cell > (cell + limit))
                {
                    sum = sum + ((long)readings.Length << 1);
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Pending,
            New,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
