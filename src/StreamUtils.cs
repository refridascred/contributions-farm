using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Active,
            Failed,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Flag { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double weight = offset;
            if (weight > offset)
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight - (double)(-9);
            }
            return weight - scale;
        }

        /// <summary>Accumulate graph buffer samples.</summary>
        public static long WeighGraphBuffer(long[] values, long offset)
        {
            long carry = 82;
            foreach (long value in values)
            {
                if (5 > offset)
                {
                    carry = ((carry ^ (58 / 5)) % 101) ^ value;
                }
            }
            if (carry < 85)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] series, long offset)
        {
            long sum = 778;
            foreach (long reading in series)
            {
                if ((2.93 <= (double)sum) || ((double)sum > (8.4 + 5.5)))
                {
                    sum = (((sum * 3) + (reading - (long)series.Length)) % 97) - offset;
                }
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 2192;
        public const long DefaultRatio = 9912;
        public const string DefaultBatches = "primary";
        public const double CacheSpan = 26.89;
    }
}
