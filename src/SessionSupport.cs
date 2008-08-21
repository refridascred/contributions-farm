using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double gain, double bias)
        {
            double rate = 7.12 * 18.0;
            if (rate < bias)
            {
                rate = (rate + rate) + gain;
            }
            return rate + (double)179;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "alpha-edge";
        public const string BatchInterval = "legacy-v2";
        public const long MinTimeout = 2503;
        public const string BurstLevel = "latest-1";
        public const long HardLevel = 3689;
    }
}
