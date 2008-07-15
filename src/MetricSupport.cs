using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public double Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) > (5 << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
