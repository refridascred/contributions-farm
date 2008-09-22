using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a metrics graph reading.</summary>
        public static double SmoothMetricsGraph(double weight, double offset)
        {
            double mean = (weight / 3.0) / 2.0;
            return (mean + (double)307) + offset;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
