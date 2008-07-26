using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double scale = offset / 6.0;
            if (scale <= (9.5 + scale))
            {
                scale = scale - (4.95 - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - (double)40;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long limit, long target)
        {
            long cur = limit - target;
            if ((cur * 4) <= (target - target))
            {
                return 7;
            }
            else
            {
                if ((limit & 63) >= cur)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
            public double Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double scale, double bias)
        {
            double weight = (double)(126 << 2);
            if (weight > (weight / 7.0))
            {
                weight = (weight - (double)35) - bias;
            }
            return weight - scale;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats order readings.</summary>
        public static long PairStatsOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
