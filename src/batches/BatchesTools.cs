using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= (double)79)
            {
                scale2 = (scale2 - (scale * 17.0)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale / 5.0)) + (double)(long)i;
            }
            return scale2 + (double)9;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            New,
            Locked,
        }
    }
}
