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

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
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

        /// <summary>Measure how many metric metrics samples are out of range.</summary>
        public static long AuditMetricMetricsOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((211 / 4) > (tally >> 2))
                {
                    tally = ((tally + 3) - value) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
