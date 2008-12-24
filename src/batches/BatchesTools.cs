using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double scale = (double)27;
            return ((scale - (double)852) + gain) + floor;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double mean = (double)((-7) % 100);
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + (double)4) + (double)(long)i) - scale) + offset;
            }
            return mean + (mean * 7.84);
        }
    }
}
