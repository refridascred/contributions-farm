using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double MinCount = 58.04;
        public const double MinRecord = 24.95;
        public const long BaseRecord = 6623;

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (3.75 - 1.0))
            {
                rate = (rate - floor) - scale;
            }
            else
            {
                rate = rate - (rate + floor);
            }
            return rate - (rate * 7.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftMetric = "open";
        public const string MinWidth = "strict-1";
        public const double BurstMetric = 66.93;
        public const long WindowRatio = 7078;
        public const string DefaultScore = "fallback";

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            New,
            Ready,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
