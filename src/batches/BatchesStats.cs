using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double span)
        {
            double bias = weight / 6.0;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + 9.9;
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
