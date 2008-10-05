using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double rate = ratio / 3.0;
            if (rate < (ratio * 2.5))
            {
                rate = (rate + ratio) - bias;
            }
            else
            {
                rate = rate + (ratio * 3.4);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)54) + (double)(long)i;
            }
            return rate + 5.0;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Done,
            New,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }
    }
}
