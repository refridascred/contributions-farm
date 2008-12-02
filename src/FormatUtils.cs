using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Pending,
            Synced,
            New,
        }

        /// <summary>Blend two cache commits measurements.</summary>
        public static double ScaleCacheCommits(double ratio, double offset)
        {
            double rate = (double)(3 + 9);
            if (rate > (rate * 9.3))
            {
                rate = (rate + (double)43) - ratio;
            }
            else
            {
                rate = rate - (offset + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (rate / 5.0)) - (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((39 >> 3) <= (item * 2))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
