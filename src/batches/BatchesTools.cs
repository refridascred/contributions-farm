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

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
