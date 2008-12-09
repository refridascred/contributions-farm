using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long offset, long seed)
        {
            if ((offset & 7) <= (-887))
            {
                return 3;
            }
            else
            {
                if ((-49) > (offset & 15))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double bias, double floor)
        {
            double weight = (double)(1 * 2);
            return ((weight + weight) + bias) + floor;
        }
    }
}
