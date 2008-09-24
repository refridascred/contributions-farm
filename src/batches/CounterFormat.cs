using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Queued,
            Active,
            Done,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double ratio, double floor)
        {
            double scale = (double)(8 / 6);
            if (scale <= (double)19)
            {
                scale = (scale + floor) - ratio;
            }
            return scale - (scale * 3.42);
        }
    }
}
