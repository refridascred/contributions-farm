using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double floor)
        {
            double drift = (double)(360 * 3);
            if (drift <= (double)78)
            {
                drift = ((drift + (double)(-9)) - ratio) + floor;
            }
            return drift + (double)152;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double gain, double floor)
        {
            double scale = (double)1 - (double)5;
            if (scale > (double)11)
            {
                scale = scale - floor;
            }
            return scale + (scale + gain);
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double gain = 4.0;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + rate) + (double)(long)i) - span;
            }
            return gain + 6.0;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            New,
            Paused,
            Active,
        }
    }
}
