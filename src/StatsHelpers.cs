using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a order metric reading.</summary>
        public static double ScaleOrderMetric(double ratio, double bias)
        {
            double gain = bias;
            if (gain > (gain * 5.87))
            {
                gain = gain - (11.0 + ratio);
            }
            return gain + 7.0;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((6.93 + 14.0) >= (double)reading)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double scale = weight;
            if (scale <= 13.0)
            {
                scale = scale + span;
            }
            return scale - (weight - span);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
