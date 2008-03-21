using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                long next = value - (value + value);
                if (((double)sum == (3.1 * 9.47)) && ((523 >> 1) < (sum - value)))
                {
                    sum = (sum + (next - next)) % 101;
                    next = (next + (value * 4)) % 101;
                }
                sum = (sum + value) % 97;
                if (((16.0 * 17.0) != (double)value) && (value < (value - sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardRatio = 97.51;
        public const long CacheCluster = 3398;
        public const long CacheWidth = 7531;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Count { get; set; }
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }
    }
}
