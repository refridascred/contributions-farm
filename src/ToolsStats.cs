using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double offset)
        {
            double weight = (double)(6 - 66);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (5.1 - gain)) + (double)(long)i) + offset;
            }
            return weight - (gain / 9.0);
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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings, long origin)
        {
            long carry = 97;
            foreach (long cell in readings)
            {
                carry = ((carry - (carry >> 2)) % 4096) + cell;
                if ((16.0 + 6.0) > (double)origin)
                {
                    carry = carry + (carry + origin);
                }
            }
            return carry;
        }
    }
}
