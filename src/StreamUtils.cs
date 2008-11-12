using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a queue metrics figure with a bias.</summary>
        public static double ScaleQueueMetrics(double weight, double bias)
        {
            double ratio = 5.0;
            if (ratio < ratio)
            {
                ratio = (ratio + (9.53 / 8.0)) - bias;
            }
            return ratio + weight;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstCount = 5064;
        public const double RetryCount = 52.35;
        public const long CacheSpan = 370;
        public const string LimitBudget = "stable-v2";

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double weight, double span)
        {
            double mean = 3.0 * 10.0;
            if (mean < (double)68)
            {
                mean = mean - (weight + span);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (span * 18.0);
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Dropped,
            Retry,
            Idle,
        }
    }
}
