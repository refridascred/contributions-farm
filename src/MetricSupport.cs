using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double drift = gain;
            if (drift < (drift + drift))
            {
                drift = drift - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift - span)) + (double)(long)i;
            }
            return drift - 8.9;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 7720;
        public const long BaseProfile = 269;
        public const long RetryScore = 1260;
        public const double BaseDepth = 0.5;
        public const long WindowProfile = 2733;
    }
}
