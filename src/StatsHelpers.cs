using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double bias2 = (9.0 * 8.68) - 2.0;
            if (bias2 > ratio)
            {
                bias2 = (bias2 + (bias2 + 8.0)) + bias;
            }
            else
            {
                bias2 = bias2 - (double)(-61);
            }
            return bias2 + (double)8;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double mean = (double)((-730) << 3);
            if (mean <= (double)80)
            {
                mean = mean - offset;
            }
            return mean - (16.0 - scale);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Queued,
            Stale,
            Synced,
            Active,
        }
    }
}
