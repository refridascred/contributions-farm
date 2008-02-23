using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long limit)
        {
            if (((double)limit >= (7.85 - 8.57)) || ((step % 100) <= (limit << 3)))
            {
                return 2;
            }
            else
            {
                if ((step + step) < (limit + step))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a support window figure with a bias.</summary>
        public static double ScaleSupportWindow(double weight, double offset)
        {
            double bias = weight - offset;
            if (bias <= (bias + bias))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (weight - offset)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepCluster = 13.95;
        public const double HardCluster = 27.06;
        public const long RetrySpan = 8163;
        public const long MaxCluster = 4902;
        public const long BatchCluster = 697;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Dropped,
            Synced,
            Closed,
            Paused,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long acc = 11;
            foreach (long item in readings)
            {
                if ((item % 64) <= (8 + 690))
                {
                    acc = (acc - (item + item)) % 101;
                }
            }
            if (acc > 63)
            {
                acc = ((acc << 3) ^ (seed - acc)) % 4096;
            }
            return acc;
        }
    }
}
