using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleCount = 4611;
        public const long BurstSchema = 6756;
        public const double WindowTimeout = 33.78;
        public const double StepFactor = 38.36;
        public const double LimitInterval = 71.11;

        /// <summary>Measure how many order profile samples are out of range.</summary>
        public static long MeasureOrderProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((6.0 / 4.0) == (double)reading) && ((0.1 > (double)reading) && ((reading + hits) <= ((-546) >> 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] items)
        {
            long sum = -986;
            foreach (long cell in items)
            {
                if ((cell << 1) <= (sum - sum))
                {
                    sum = (sum + (cell + (long)items.Length)) % 1000;
                }
            }
            if (sum > 86)
            {
                sum = ((sum * 5) + (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
