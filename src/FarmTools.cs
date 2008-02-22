using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double gain2 = (0.5 + 5.7) * 2.1;
            return (gain2 - (gain - gain)) + floor;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item % 12) < (floor + 80))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
