using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3531;
        public const long BatchMetrics = 1806;
        public const double MinCount = 37.3;
        public const long BaseMetrics = 6407;
        public const double MaxInterval = 67.64;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Retry,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Match up metric batch samples.</summary>
        public static long CompareMetricBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double scale, double span)
        {
            double bias = 8.05 / 3.0;
            if (bias >= 1.71)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias + (7.16 * 0.55);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - scale) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long offset)
        {
            long acc = 4;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc << 2) ^ (sample >> 5)) - (long)i;
                }
                if (((double)(long)levels.Length == (6.1 * 19.0)) || (27 > (62 + offset)))
                {
                    acc = acc ^ sample;
                }
            }
            if (acc < 85)
            {
                acc = acc ^ (offset + offset);
            }
            return acc;
        }
    }
}
