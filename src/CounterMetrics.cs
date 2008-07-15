using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Active,
            Closed,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < floor)
            {
                mean = mean + (mean + ratio);
            }
            return mean - (ratio / 8.0);
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double bias, double floor)
        {
            double rate = 8.5;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - bias) + (double)(long)i) + floor;
            }
            return rate - (double)7;
        }
    }
}
