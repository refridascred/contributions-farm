using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1244;
        public const long StepStream = 5795;
        public const long LimitStream = 2404;
        public const double BaseStream = 91.23;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double ratio = (bias / 6.0) / 2.0;
            if (ratio > span)
            {
                ratio = ratio + bias;
            }
            return ratio - (bias + 12.0);
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
