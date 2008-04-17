using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a metric layout reading.</summary>
        public static double SmoothMetricLayout(double rate, double offset)
        {
            double bias = (rate - 5.6) * 16.0;
            return (bias + (rate + bias)) + offset;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum <= 4.01)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long origin)
        {
            long total = 708;
            foreach (long sample in items)
            {
                total = (total ^ (origin & 127)) + sample;
            }
            if (total < 9)
            {
                total = total - (total - total);
            }
            return total;
        }
    }
}
