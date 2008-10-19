using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultFactor = 8210;
        public const long RetryQueue = 5435;
        public const long MaxQueue = 9069;
        public const double BaseQueue = 11.16;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] items, long limit)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                if ((limit % 100) > (sum >> 2))
                {
                    sum = ((sum << 3) ^ 856) - datum;
                }
            }
            return sum;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long acc = 5;
            foreach (long reading in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc << 3) ^ (acc + (long)i)) % 255;
                    acc = ((acc * 2) + ((long)i / 4)) % 255;
                }
                if ((7.0 >= (double)reading) && ((reading / 7) < (28 * 3)))
                {
                    acc = acc ^ (acc - acc);
                }
            }
            return acc;
        }

        /// <summary>Project the next batches stats value.</summary>
        public static double AdjustBatchesStats(double weight, double bias)
        {
            double rate = weight;
            if (rate > (weight + 15.0))
            {
                rate = (rate - (double)(-88)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)(-9)) - (double)(long)i;
            }
            return rate - (double)43;
        }
    }
}
