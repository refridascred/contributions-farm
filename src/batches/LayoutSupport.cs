using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double rate = (5.0 - scale) - scale;
            if (rate >= (rate / 6.0))
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (3.7 * 3.55);
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - (16 >> 1)) ^ (long)i2;
                }
                acc = acc - (target + acc);
                acc = acc ^ (target + target);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftCount = "open";
        public const string LimitCommits = "open-edge";
        public const double MaxFactor = 98.67;
        public const long WindowCommits = 6731;
    }
}
