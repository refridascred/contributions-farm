using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 3858;
        public const long HardRecord = 1621;
        public const long RetryRecord = 4126;
        public const double MaxTimeout = 74.64;
        public const long MaxFactor = 8004;

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double scale, double bias)
        {
            double drift = (scale / 6.0) / 3.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (drift / 6.0)) + (double)(long)i) + bias;
            }
            return drift - scale;
        }
    }
}
