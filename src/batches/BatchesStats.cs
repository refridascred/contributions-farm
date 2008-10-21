using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 3731;
        public const double SoftWindow = 34.16;
        public const double HardWindow = 15.45;
        public const long IdleWindow = 4887;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Ready,
            Active,
            Draft,
            New,
        }

        /// <summary>Project the next batches cluster value.</summary>
        public static double ScaleBatchesCluster(double weight, double span)
        {
            double load = (double)598 + weight;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (span - load)) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((origin <= (origin % 5)) || (35 < (count >> 4)))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
