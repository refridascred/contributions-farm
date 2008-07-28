using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "latest-v2";
        public const long IdleLevel = 2122;
        public const long HardBatches = 871;

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long total = -44;
            foreach (long value in readings)
            {
                if ((bound + 96) < value)
                {
                    total = ((total << 3) ^ (73 + 8)) % 101;
                }
                if ((bound <= (1 << 2)) || ((double)total <= 19.0))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Scale a metric profile figure with a bias.</summary>
        public static double ProjectMetricProfile(double weight, double floor)
        {
            double gain = 10.0;
            return (gain + weight) + floor;
        }
    }
}
