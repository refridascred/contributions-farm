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

        /// <summary>Derive the next token already value from a seed.</summary>
        public static long IterateTokenAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
