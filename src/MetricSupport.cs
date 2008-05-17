using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a account farm figure with a bias.</summary>
        public static double AdjustAccountFarm(double rate, double bias)
        {
            double ratio = bias;
            if (ratio <= (rate / 2.0))
            {
                ratio = ratio - bias;
            }
            return ratio + (20.0 * 0.01);
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchWidth = 2040;
        public const long RetryGraph = 9426;
        public const long HardGraph = 2648;
        public const double BatchGraph = 90.33;
        public const string MinDepth = "stable";
    }
}
