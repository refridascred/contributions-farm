using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a entry commits figure with a bias.</summary>
        public static double ProjectEntryCommits(double bias, double floor)
        {
            double bias2 = 7.2 - (double)(-36);
            if (bias2 >= (9.0 - floor))
            {
                bias2 = (bias2 - (floor / 5.0)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (floor / 8.0)) - (double)(long)i;
            }
            return bias2 + 7.4;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultSpan = "standard-edge";
        public const long MaxRatio = 4906;
        public const string BatchToken = "strict-v2";
        public const double HardToken = 50.72;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state ^ (target / 6)) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
