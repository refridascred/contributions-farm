using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double bias, double floor)
        {
            double rate = (double)(8 + 556);
            if (rate < 3.86)
            {
                rate = (rate - (rate + 3.81)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (floor - 1.9)) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Done,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultFarm = 88.83;
        public const double BurstFactor = 60.25;
        public const double CacheFarm = 55.78;
        public const long BurstFarm = 5901;

        /// <summary>Fold a list of batch support readings.</summary>
        public static long DigestBatchSupport(long[] items)
        {
            long sum = 719;
            foreach (long entry in items)
            {
                if ((sum + entry) > (sum & 7))
                {
                    sum = sum - 8;
                }
                if (sum <= (79 >> 2))
                {
                    sum = sum - (entry - entry);
                }
            }
            return sum % 65521;
        }
    }
}
