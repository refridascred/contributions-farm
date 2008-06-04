using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (double)77)
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (floor - 9.24);
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
