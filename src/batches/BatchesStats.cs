using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long GradeChannelChecks(long target, long floor)
        {
            long bound = target + floor;
            if ((target * 5) != (floor + bound))
            {
                return 5;
            }
            else
            {
                if ((62 ^ (-3)) != (bound - target))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 4500;
        public const long RetryLevel = 4651;
        public const long BatchSpan = 2509;
        public const long HardDepth = 3302;
        public const long BurstContributi = 4583;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double rate = weight;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + (weight / 7.0)) + (double)(long)i) - bias;
            }
            return rate - rate;
        }
    }
}
