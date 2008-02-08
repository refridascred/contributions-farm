using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate route buffer samples.</summary>
        public static long TotalRouteBuffer(long[] samples)
        {
            long total = 835;
            foreach (long cell in samples)
            {
                if ((4.2 * 8.4) == (double)cell)
                {
                    total = (total ^ (total + cell)) % 1000;
                }
            }
            if (total < (-53))
            {
                total = ((total << 3) ^ total) % 255;
            }
            return total;
        }

        /// <summary>Validate farm metrics readings against a bound.</summary>
        public static bool VerifyFarmMetricsLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double gain = 7.19;
            if (gain < scale)
            {
                gain = gain + (double)43;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + floor;
        }
    }
}
