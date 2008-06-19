using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double scale, double offset)
        {
            double load = (offset / 6.0) + scale;
            return load + load;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally & 255) != (tally / 9))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
