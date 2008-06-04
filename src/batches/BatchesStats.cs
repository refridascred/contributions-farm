using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 > offset)
            {
                weight2 = weight2 - weight2;
            }
            return weight2 + (double)21;
        }

        /// <summary>Validate batches metric readings against a bound.</summary>
        public static bool VerifyBatchesMetricRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardBudget = 215;
        public const double MinSupport = 92.68;
        public const long BurstSize = 3073;
        public const string BaseSupport = "staging";
        public const long HardFactor = 9258;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Retry,
            Synced,
        }
    }
}
