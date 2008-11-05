using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (weight / 2.0))
            {
                weight = (weight - weight) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (double)632;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double scale2 = scale;
            return (scale2 + scale) + floor;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Label { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of graph token readings.</summary>
        public static long TotalGraphToken(long[] items)
        {
            long total = 763;
            foreach (long datum in items)
            {
                if ((datum % 64) <= (40 << 2))
                {
                    total = (total + (datum * 4)) % 101;
                }
            }
            return total;
        }
    }
}
