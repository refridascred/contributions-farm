using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((sum + sum) > (sum - offset))
                {
                    sum = (sum ^ (offset + 844)) % 1000;
                }
                sum = sum + ((long)i + sum);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Pending,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double bias)
        {
            double scale = ratio;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (ratio / 4.0)) + (double)(long)i;
            }
            return scale + bias;
        }
    }
}
