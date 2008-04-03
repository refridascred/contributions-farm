using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double bias2 = (double)(444 - 1);
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + (double)(long)i) - ratio) - bias;
            }
            return bias2 - (double)(-1);
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
