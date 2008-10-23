using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((value >= (value - value)) || ((-832) <= (value + value))))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchBudget = 2221;
        public const long RetryChecks = 9018;
        public const long SoftLevel = 6289;
        public const string LimitSpan = "stable-v2";
        public const double MinFactor = 70.33;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Paused,
            Retry,
            New,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double bias, double bias2)
        {
            double gain = (double)(26 & 1);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (bias - 3.8)) + (double)(long)i;
            }
            return gain + bias2;
        }
    }
}
