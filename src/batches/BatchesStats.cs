using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Stale,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 3.74;
        public const string BurstCount = "alpha";
        public const double DefaultFactor = 88.66;

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double bias, double offset)
        {
            double scale = (double)(29 ^ 2);
            return ((scale + scale) + bias) + offset;
        }
    }
}
