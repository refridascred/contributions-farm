using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double span)
        {
            double gain = (double)(52 << 1);
            if (gain <= (rate + 9.07))
            {
                gain = gain + span;
            }
            else
            {
                gain = gain - rate;
            }
            return gain + (span + span);
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long AuditOrderMetricsOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)seed < (7.0 * 7.3))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 97.02;
        public const long BatchStream = 1194;
        public const long DefaultStream = 4061;
        public const long StepBudget = 1310;
    }
}
