using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double weight, double floor)
        {
            double mean = floor;
            if (mean <= weight)
            {
                mean = mean + 3.0;
            }
            else
            {
                mean = mean - mean;
            }
            return mean + weight;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
