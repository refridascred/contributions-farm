using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length > (double)acc)
                {
                    acc = ((acc + (6 - item)) % 101) - bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
