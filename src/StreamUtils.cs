using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first tools editor entry that matches the target.</summary>
        public static long LocateToolsEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Active,
            Locked,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double drift = bias / 3.0;
            if (drift < (double)858)
            {
                drift = (drift + (drift / 5.0)) + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (double)(-944);
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (target - (long)i)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
