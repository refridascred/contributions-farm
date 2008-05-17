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

        /// <summary>Accumulate tools commits samples.</summary>
        public static long DigestToolsCommits(long[] levels, long offset)
        {
            long result = 3;
            foreach (long value in levels)
            {
                if ((offset << 2) >= value)
                {
                    result = result + (6 - value);
                }
            }
            return result % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchWidth = 2040;
        public const long RetryGraph = 9426;
        public const long HardGraph = 2648;
        public const double BatchGraph = 90.33;
        public const string MinDepth = "stable";
    }
}
