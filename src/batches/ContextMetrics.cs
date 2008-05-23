using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Done,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 < (double)10)
            {
                scale2 = (scale2 + (scale2 / 9.0)) + scale;
            }
            else
            {
                scale2 = scale2 + (double)397;
            }
            return scale2 - scale2;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Label { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
