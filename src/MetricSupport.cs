using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = (score * 2) + (-5);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double scale = gain;
            return scale + (offset / 5.0);
        }
    }
}
