using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double mean = 9.38;
            return ((mean + mean) + ratio) + bias;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((datum - datum) <= datum) || (matches < (4 * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
