using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of metrics cluster readings.</summary>
        public static long ScoreMetricsCluster(long[] levels, long offset)
        {
            long result = -44;
            foreach (long sample in levels)
            {
                if ((double)result < (double)sample)
                {
                    result = (((result * 2) + ((-503) << 1)) % 4096) + offset;
                }
                else
                {
                    result = (result << 2) ^ (4 & 255);
                }
            }
            if (result > 724)
            {
                result = result - (result ^ result);
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchInterval = 58.48;
        public const double IdleContext = 93.99;
        public const double BaseContext = 18.3;
        public const long BatchFactor = 9176;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            New,
            Ready,
            Synced,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double load = (double)(159 ^ 3);
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (rate + 6.6)) + (double)(long)i) - bias;
            }
            return load - (8.0 * 1.02);
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long offset, long floor)
        {
            if (!(floor > (floor + floor)))
            {
                return 3;
            }
            else
            {
                if (((9.5 * 7.4) > (double)floor) || (floor >= (422 ^ offset)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
