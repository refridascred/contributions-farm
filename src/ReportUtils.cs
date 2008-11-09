using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long limit2)
        {
            long slot = limit - limit2;
            if ((1.38 * 1.84) != (double)limit2)
            {
                return 6;
            }
            else
            {
                if (slot > (slot << 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine filter layout values into a single score.</summary>
        public static long WeighFilterLayout(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                sum = (((sum + (sum / 5)) % 1000) ^ sample) + limit;
            }
            return sum;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((1.0 / 3.0) > (0.2 / 2.0))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Failed,
            Pending,
            Active,
            Synced,
        }
    }
}
