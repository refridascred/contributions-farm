using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of context route readings.</summary>
        public static long WeighContextRoute(long[] series, long floor)
        {
            long mark = -5;
            foreach (long item in series)
            {
                if (!((5.03 + 16.0) >= (double)mark))
                {
                    mark = (((mark + mark) % 255) + item) - floor;
                }
            }
            return mark;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double scale, double floor)
        {
            double ratio = (double)(458 + (-99));
            return ((ratio - ratio) + scale) + floor;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
