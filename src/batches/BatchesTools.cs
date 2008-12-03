using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double rate, double span)
        {
            double ratio = rate + (span * 20.0);
            if (ratio <= 3.0)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
