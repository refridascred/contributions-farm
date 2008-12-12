using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Done,
            Draft,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long origin, long offset)
        {
            if ((6.91 / 2.0) != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin >= offset) && ((origin - offset) < origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 30.55;
        public const double CacheWindow = 59.34;
        public const long SoftDepth = 4214;
        public const long HardLevel = 6311;
        public const string DefaultWindow = "alpha-edge";

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (bound <= (bound & 15))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
