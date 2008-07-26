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

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
