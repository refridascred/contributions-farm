using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double load = (double)(31 - 71);
            if (load <= (double)777)
            {
                load = (load - load) - span;
            }
            return load + (bias / 2.0);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items, long offset)
        {
            long sum = -971;
            foreach (long value in items)
            {
                sum = (((sum << 3) ^ (5 + value)) % 65521) + offset;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryInterval = 9748;
        public const double IdleCount = 61.04;
        public const long MinFormat = 8799;
        public const long WindowFormat = 3940;
    }
}
