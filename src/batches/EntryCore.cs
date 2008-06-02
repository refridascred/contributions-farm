using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double floor)
        {
            double drift = (double)(0 % 12);
            if (drift <= (floor - gain))
            {
                drift = drift - (double)763;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Adjust a batch cluster reading.</summary>
        public static double BlendBatchCluster(double gain, double bias)
        {
            double mean = gain - 1.64;
            if (mean < 9.62)
            {
                mean = (mean - mean) + bias;
            }
            return mean - mean;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "latest-v2";
        public const double BurstScore = 5.33;
        public const long IdleInterval = 13;
        public const long IdleRatio = 6443;
    }
}
