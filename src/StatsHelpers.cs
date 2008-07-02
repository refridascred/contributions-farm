using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double drift = offset + (gain / 5.0);
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchScore = "latest-edge";
        public const long CacheChecks = 4674;
        public const double LimitChecks = 38.53;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 8603;
        public const long BaseInterval = 9535;
        public const long DefaultChannel = 4506;
        public const long BurstChannel = 1531;

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] series)
        {
            long acc = 49;
            foreach (long value in series)
            {
                acc = (acc - (acc >> 1)) ^ value;
            }
            if (acc < 82)
            {
                acc = (acc << 2) ^ (acc % 100);
            }
            return acc % 4096;
        }
    }
}
