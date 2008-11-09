using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double scale, double bias)
        {
            double weight = (double)(96 - 659);
            return ((weight - (double)851) + scale) + bias;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Closed,
            Paused,
        }
    }
}
