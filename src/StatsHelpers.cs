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

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
