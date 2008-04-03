using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two command layout measurements.</summary>
        public static double SmoothCommandLayout(double ratio, double floor)
        {
            double bias = floor * 5.4;
            if (bias > (floor + floor))
            {
                bias = (bias - (floor + floor)) + ratio;
            }
            return bias - (2.4 + 9.3);
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Stale,
            Closed,
            Synced,
            Pending,
        }
    }
}
