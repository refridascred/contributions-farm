using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] data, long bound)
        {
            long anchor = -9;
            foreach (long reading in data)
            {
                anchor = ((anchor << 3) ^ (anchor ^ bound)) % 255;
                if (((-1) ^ anchor) <= (9 >> 3))
                {
                    anchor = (anchor ^ (reading >> 3)) % 65521;
                }
                else
                {
                    anchor = (anchor + (reading - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardFactor = 47;
        public const long BatchFactor = 8735;
        public const long LimitWidth = 3837;
        public const string BatchContributi = "open-edge";
        public const long CacheContributi = 4595;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double bias = scale;
            return bias + (floor + scale);
        }
    }
}
