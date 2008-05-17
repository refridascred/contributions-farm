using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Draft,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double bias, double offset)
        {
            double weight = (double)(515 ^ (-3));
            if (weight < offset)
            {
                weight = (weight - weight) + bias;
            }
            else
            {
                weight = weight - (offset * 14.0);
            }
            return weight - (offset / 8.0);
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double bias, double floor)
        {
            double mean = (double)(2 - 249);
            return ((mean - (double)19) + bias) + floor;
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] values, long origin)
        {
            long mark = 95;
            foreach (long datum in values)
            {
                mark = (((mark * 4) + (5 + 142)) ^ datum) - origin;
            }
            return mark % 1000;
        }
    }
}
