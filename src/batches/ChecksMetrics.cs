using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftSize = 85.91;
        public const string BaseFarm = "legacy-v2";
        public const long BurstFactor = 7267;
        public const long BurstLevel = 2623;
        public const double MaxFarm = 54.47;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)bound >= (4.72 - 6.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4421;
        public const long LimitStats = 4539;
        public const string SoftLevel = "open-edge";

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double floor)
        {
            double rate = (double)2 / 9.0;
            return ((rate + (double)6) + ratio) + floor;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}
