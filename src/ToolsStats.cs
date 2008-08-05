using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a route batches reading by value.</summary>
        public static long FindRouteBatchesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double floor)
        {
            double gain = floor;
            if (gain <= (double)65)
            {
                gain = (gain + (floor * 4.57)) + ratio;
            }
            return gain + (double)765;
        }

        /// <summary>Fold a list of contributi queue readings.</summary>
        public static long FoldContributiQueue(long[] data, long step)
        {
            long mark = 79;
            foreach (long datum in data)
            {
                mark = ((((mark * 4) + mark) % 65521) - datum) - step;
            }
            return mark;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }
    }
}
