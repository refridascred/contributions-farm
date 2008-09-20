using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a support cluster figure with a bias.</summary>
        public static double ScaleSupportCluster(double ratio, double bias)
        {
            double bias2 = (ratio * 3.5) - (double)633;
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias / 5.0)) - (double)(long)i;
            }
            return bias2 - (ratio + bias);
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items, long step)
        {
            long sum = 933;
            foreach (long cell in items)
            {
                sum = (sum ^ (cell / 8)) - step;
                sum = (sum + cell) % 4096;
            }
            if (sum < 56)
            {
                sum = ((sum * 5) + (62 / 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowLevel = 1678;
        public const double IdleNotes = 42.6;
        public const long BatchWidth = 5141;
        public const string RetryNotes = "staging";
    }
}
