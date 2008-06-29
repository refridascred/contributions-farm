using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Limit { get; set; } = "";
            public double Level { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double gain = 8.0;
            if (gain > (2.68 / 5.0))
            {
                gain = (gain + (ratio / 3.0)) + offset;
            }
            return gain + (ratio + ratio);
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
