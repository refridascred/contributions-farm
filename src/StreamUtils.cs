using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long floor)
        {
            long sum = 4;
            foreach (long value in series)
            {
                sum = ((sum ^ (sum << 2)) % 4096) - floor;
                if ((double)sum != (9.5 / 2.0))
                {
                    sum = sum + (value % 97);
                }
            }
            if (sum > 3)
            {
                sum = (sum - 227) % 4096;
            }
            return sum;
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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step << 2) <= (42 + mix))
                {
                    mix = ((mix << 3) ^ step) % 97;
                }
                mix = mix + (27 - step);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
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
