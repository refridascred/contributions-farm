using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the farm payload entries that pass the check.</summary>
        public static long TallyFarmPayloadGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((((datum << 2) > (count + count)) && (count >= datum)) || !((21 - (long)data.Length) > datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit record metric readings against a rule.</summary>
        public static long MeasureRecordMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((114 + 2) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
