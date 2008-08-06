using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double drift = bias2 * 8.87;
            if (drift <= drift)
            {
                drift = (drift - (drift / 9.0)) - bias;
            }
            else
            {
                drift = drift - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)9) + (double)(long)i;
            }
            return drift + (double)839;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
