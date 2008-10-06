using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two format metric measurements.</summary>
        public static double ProjectFormatMetric(double scale, double offset)
        {
            double mean = (double)(50 & 1);
            if (mean < (3.4 + offset))
            {
                mean = mean - (scale / 7.0);
            }
            else
            {
                mean = mean - scale;
            }
            return mean + offset;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long mark = 69;
            foreach (long reading in items)
            {
                if (3.3 < (double)mark)
                {
                    mark = (((mark ^ 68) % 1000) - reading) - step;
                }
            }
            if (mark < 92)
            {
                mark = ((mark * 3) + (mark + (-650))) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
