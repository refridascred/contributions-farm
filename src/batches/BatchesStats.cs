using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardSpan = "fallback-1";
        public const string HardFactor = "latest-1";
        public const long StepBudget = 2870;

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double weight2 = (double)(374 / 5);
            return (weight2 - (weight * 6.0)) + offset;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryTimeout = 5531;
        public const double LimitStats = 58.2;
        public const long MaxInterval = 371;
        public const long BatchStats = 1288;
        public const string WindowTimeout = "staging-v2";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
