using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the stats metric series from a seed.</summary>
        public static long SeriesStatsMetric(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if (0.8 <= (double)seed)
                {
                    mix = ((mix << 2) ^ 26) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long result = 813;
            foreach (long cell in samples)
            {
                result = ((result - (long)samples.Length) % 4096) - target;
                result = (result * 3) + (cell - cell);
                if (!((2.0 / 6.0) < (double)result))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 < bias)
            {
                ratio2 = (ratio2 - bias) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (ratio2 - ratio2)) - (double)(long)i;
            }
            return ratio2 + (double)8;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels)
        {
            long mark = 942;
            foreach (long reading in levels)
            {
                if ((reading + 41) > (mark >> 4))
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }
    }
}
