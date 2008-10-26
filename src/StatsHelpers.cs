using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((item + item) <= (item + (long)items.Length)) || (count <= item))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples, long step)
        {
            long mark = 1;
            foreach (long item in samples)
            {
                if (((step >> 1) <= (240 << 2)) && ((double)item > (5.83 + 2.7)))
                {
                    mark = (mark << 3) ^ (step + step);
                }
                else
                {
                    mark = (mark * 2) + item;
                }
                if ((step - 8) >= (step - item))
                {
                    mark = (mark * 5) + step;
                }
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 > 8.0)
            {
                bias3 = bias3 - (5.1 - bias);
            }
            return bias3 - bias2;
        }
    }
}
