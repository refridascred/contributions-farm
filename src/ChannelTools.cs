using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
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
