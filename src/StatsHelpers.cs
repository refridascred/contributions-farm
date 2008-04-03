using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Paused,
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (ratio + scale)) - (double)(long)i;
            }
            return scale - (double)408;
        }

        /// <summary>Audit report farm readings against a rule.</summary>
        public static long MeasureReportFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long total = 680;
            foreach (long value in samples)
            {
                total = ((total + (value + total)) % 101) + seed;
            }
            return total % 4096;
        }
    }
}
