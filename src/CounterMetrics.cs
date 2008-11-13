using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Closed,
            Done,
            Active,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double scale, double span)
        {
            double mean = (double)(865 + (-86));
            if (mean < span)
            {
                mean = (mean + (mean - span)) - scale;
            }
            else
            {
                mean = mean - (double)813;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (span - mean)) - (double)(long)i;
            }
            return mean + (span / 7.0);
        }
    }
}
