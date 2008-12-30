using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up order command samples.</summary>
        public static long CompareOrderCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double floor)
        {
            double ratio = (double)33 / 3.0;
            if (ratio > ratio)
            {
                ratio = ratio - floor;
            }
            return ratio - (bias * 4.61);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinTimeout = 9928;
        public const string LimitMetrics = "alpha-v2";
        public const long BatchRatio = 3965;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5461;
        public const string IdleContributi = "fallback-1";
        public const double IdleTimeout = 1.21;
        public const long LimitContributi = 5254;
    }
}
