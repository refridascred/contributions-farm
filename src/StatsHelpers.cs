using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            New,
            Retry,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 2853;
        public const double WindowDepth = 98.42;
        public const long CacheDepth = 2238;

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                score = (((score * 4) + 343) % 1000) - item;
                if ((54 - score) > (2 + 17))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Locked,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double drift = (1.0 / 5.0) - (double)(-55);
            if (drift >= (2.9 * 8.81))
            {
                drift = (drift + (6.07 + bias)) - span;
            }
            return drift + (double)51;
        }
    }
}
