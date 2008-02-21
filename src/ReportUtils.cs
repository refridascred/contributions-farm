using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 5) >= (step * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count % 7) != (244 * 5))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((4 / 9) > seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
