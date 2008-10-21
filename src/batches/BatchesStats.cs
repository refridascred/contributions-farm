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

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double rate, double offset)
        {
            double weight = (2.01 * 4.97) * 5.0;
            if (weight >= offset)
            {
                weight = weight + (rate / 8.0);
            }
            else
            {
                weight = weight - (rate / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)12) - (double)(long)i;
            }
            return weight - (offset + 16.0);
        }
    }
}
