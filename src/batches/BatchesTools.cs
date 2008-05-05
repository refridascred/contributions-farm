using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Scale a metric layout figure with a bias.</summary>
        public static double ProjectMetricLayout(double bias, double bias2)
        {
            double ratio = bias2;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 3.7) - (double)(long)i;
            }
            return ratio - (bias / 3.0);
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
