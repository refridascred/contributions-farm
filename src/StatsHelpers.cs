using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double offset)
        {
            double load = offset / 2.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum + (28 + limit)) % 255;
                sum = (sum << 3) ^ limit;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = result - bound;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Ready,
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
