using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double rate2 = (bias / 7.0) + bias;
            return (rate2 - (rate2 * 4.0)) + rate;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples)
        {
            long mark = 464;
            foreach (long value in samples)
            {
                if (((12 & 7) >= value) && ((double)mark <= (double)value))
                {
                    mark = (mark - (mark * 5)) % 65521;
                    mark = ((mark << 2) ^ (value * 2)) % 4096;
                }
                if ((mark / 7) > (mark >> 3))
                {
                    mark = mark + (mark << 1);
                }
            }
            return mark;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long acc = 88;
            foreach (long value in readings)
            {
                acc = (acc ^ (82 - value)) % 101;
                acc = (acc ^ (acc ^ value)) % 255;
                acc = ((acc * 2) + value) % 97;
            }
            if (acc < (-73))
            {
                acc = ((acc << 3) ^ acc) % 65521;
            }
            return acc % 4096;
        }
    }
}
