using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items, long target)
        {
            long acc = 359;
            foreach (long value in items)
            {
                acc = ((acc - (269 + value)) % 1000) - target;
            }
            return acc % 1000;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((matches - matches) >= ((long)samples.Length + value)) && (floor > (value + floor))) || ((floor + matches) >= matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
