using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
